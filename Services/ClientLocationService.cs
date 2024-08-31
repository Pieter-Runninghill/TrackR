
using System.Net.Http.Json;
using TrackR.Models;
using TrackR.Services.Interface;

namespace TrackR.Services
{
    public class ClientLocationService : IClientLocationService
    {
        private readonly HttpClient _httpClient;

        public ClientLocationService(HttpClient httpclient)
        {
            _httpClient = httpclient;
        }

        public async Task<List<ClientLocation>> GetAllClientLocations()
        {
            try
            {
                var response = await _httpClient.GetAsync("ClientLocation");

                if (response.IsSuccessStatusCode)
                {
                    var clientLocations = await response.Content.ReadFromJsonAsync<List<ClientLocation>>();

                    if (clientLocations != null)
                    {
                        return clientLocations;
                    }
                }

                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ClientLocation> GetClientLocationById(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"ClientLocation/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var clientLocation = await response.Content.ReadFromJsonAsync<ClientLocation>();

                    if (clientLocation != null)
                    {
                        return clientLocation;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
