using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Vista.Data.ViewModels.APIResponse;

namespace Vista.Services
{
    /// <summary>
    /// Interfaz para el servicio que interactúa con la API de Georef.
    /// </summary>
    public interface IGeorefService
    {
        /// <summary>
        /// Valida la conexión a la API de Georef.
        /// </summary>
        /// <returns>
        /// Un <see cref="Task{TResult}"/> que representa la operación asíncrona. El valor resultante es <c>true</c> si la conexión es exitosa; de lo contrario, <c>false</c>.
        /// </returns>
        Task<bool> CheckApiConnectionAsync();

        /// <summary>
        /// Obtiene sugerencias de direcciones a partir del nombre de una calle.
        /// </summary>
        /// <param name="calle">Nombre o parte del nombre de la calle a buscar.</param>
        /// <returns>
        /// Una lista de objetos <see cref="Direccion"/> con las coincidencias encontradas. Si no hay conexión o falla la búsqueda, se devuelve una lista vacía.
        /// </returns>
        Task<List<Direccion>> GetStreetSuggestionsAsync(string calle);
    }

    public class GeorefService : IGeorefService
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsRuntime;

        public GeorefService(HttpClient httpClient, IJSRuntime jsRuntime)
        {
            _httpClient = httpClient;
            _jsRuntime = jsRuntime;

            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
        }

        public async Task<bool> CheckApiConnectionAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://apis.datos.gob.ar/georef/api/provincias");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorMsg = $"API connection failed with status code: {response.StatusCode}";
                    await LogErrorToConsoleAsync(errorMsg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                await LogErrorToConsoleAsync($"Error checking API connection: {ex.Message}");
                return false;
            }
        }

        public async Task<List<Direccion>> GetStreetSuggestionsAsync(string calle)
        {
            if (!string.IsNullOrWhiteSpace(calle))
            {
                var isConnected = await CheckApiConnectionAsync();
                if (!isConnected)
                {
                    await LogErrorToConsoleAsync("API connection failed. Street suggestions will not be fetched.");
                    return new List<Direccion>();
                }

                var calleEscaped = Uri.EscapeDataString(calle.Trim());
                var url = $"https://apis.datos.gob.ar/georef/api/direcciones?direccion={calleEscaped}&localidad=Chivilcoy&provincia=Buenos%20Aires";

                try
                {
                    var response = await _httpClient.GetFromJsonAsync<GeorefResponse>(url);
                    return response?.Direcciones ?? new List<Direccion>();
                }
                catch (Exception ex)
                {
                    await LogErrorToConsoleAsync($"Error fetching street suggestions: {ex.Message}");
                    return new List<Direccion>();
                }
            }
            return new List<Direccion>();
        }

        private async Task LogErrorToConsoleAsync(string message)
        {
            await _jsRuntime.InvokeVoidAsync("console.error", message);
        }
    }
}
