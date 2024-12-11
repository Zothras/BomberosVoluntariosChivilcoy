using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Collections.Generic;
using Vista.Data.Models.Salidas.Componentes;
using Microsoft.JSInterop;

namespace Vista.Services
{
    public class GeorefService
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
