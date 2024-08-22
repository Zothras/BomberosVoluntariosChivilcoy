using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Collections.Generic;
using Vista.Data.Models.Salidas.Componentes;
using Microsoft.JSInterop; // Para invocar métodos JavaScript desde C#

namespace Vista.Services
{
    public class GeorefService
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsRuntime; // Para llamar a la consola del navegador

        public GeorefService(HttpClient httpClient, IJSRuntime jsRuntime)
        {
            _httpClient = httpClient;
            _jsRuntime = jsRuntime;
        }

        public async Task<bool> CheckApiConnectionAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://apis.datos.gob.ar/georef/api/");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                await LogErrorToConsoleAsync($"Error checking API connection: {ex.Message}");
                return false;
            }
        }

        public async Task<List<string>> GetStreetSuggestionsAsync(string calle)
        {
            if (!string.IsNullOrWhiteSpace(calle))
            {
                var isConnected = await CheckApiConnectionAsync();
                if (!isConnected)
                {
                    await LogErrorToConsoleAsync("API connection failed. Street suggestions will not be fetched.");
                    return new List<string>();
                }

                var calleEscaped = Uri.EscapeDataString(calle.Trim());
                var url = $"https://apis.datos.gob.ar/georef/api/direcciones?direccion={calleEscaped}&localidad=Chivilcoy&provincia=Buenos%20Aires";

                try
                {
                    var response = await _httpClient.GetFromJsonAsync<GeorefResponse>(url);
                    return response?.direcciones?.Select(d => d.calle.nombre).Distinct().ToList() ?? new List<string>();
                }
                catch (Exception ex)
                {
                    await LogErrorToConsoleAsync($"Error fetching street suggestions: {ex.Message}");
                    return new List<string>();
                }
            }
            return new List<string>();
        }

        private async Task LogErrorToConsoleAsync(string message)
        {
            // Escribe el error en la consola del navegador
            await _jsRuntime.InvokeVoidAsync("console.error", message);
            // También lo escribimos en la consola del servidor
            Console.WriteLine(message);
        }
    }
}
