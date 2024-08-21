using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Collections.Generic;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Services
{
    public class GeorefService
    {
        private readonly HttpClient _httpClient;

        public GeorefService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<string>> GetStreetSuggestionsAsync(string calle)
        {
            if (!string.IsNullOrWhiteSpace(calle))
            {
                var calleEscaped = Uri.EscapeDataString(calle.Trim());
                var url = $"https://apis.datos.gob.ar/georef/api/direcciones?direccion={calleEscaped}&localidad=Chivilcoy&provincia=Buenos%20Aires";

                try
                {
                    var response = await _httpClient.GetFromJsonAsync<GeorefResponse>(url);
                    return response?.direcciones?.Select(d => d.calle.nombre).Distinct().ToList() ?? new List<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching street suggestions: {ex.Message}");
                    return new List<string>();
                }
            }
            return new List<string>();
        }
    }
}
