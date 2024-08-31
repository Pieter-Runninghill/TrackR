using System.Net.Http.Json;
using TrackR.Models;
using TrackR.Services.Interface;

namespace TrackR.Services
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;

        public ClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Client>> Getall()
        {
            try
            {
                var response = await _httpClient.GetAsync("Client");

                if (response.IsSuccessStatusCode)
                {
                    var clients = await response.Content.ReadFromJsonAsync<List<Client>>();

                    if (clients != null)
                    {
                        return clients;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Client> GetClientById(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"Client/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var client = await response.Content.ReadFromJsonAsync<Client>();

                    if (client != null)
                    {
                        return client;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
