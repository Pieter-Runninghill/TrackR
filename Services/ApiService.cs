using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TrackR.Models;
using Microsoft.Identity.Client;

namespace TrackR.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<bool> ExportUserDataAsync(AuthenticationResult authResult, UserData userData)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

            var jsonContent = JsonConvert.SerializeObject(userData);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://api.yourdomain.com/userdata", content);

            return response.IsSuccessStatusCode;
        }

        public async Task<UserData> GetUserDataAsync(AuthenticationResult authResult)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

            var response = await _httpClient.GetAsync("https://api.yourdomain.com/userdata");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var userData = JsonConvert.DeserializeObject<UserData>(jsonResponse);
                return userData;
            }

            return null;
        }

        public async Task<UserData> GetUserByEmailAsync(AuthenticationResult authResult)
        {
            return null;
        }
    }
}
