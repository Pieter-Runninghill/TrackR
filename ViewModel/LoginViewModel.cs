using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Net;
using System.Net.Http.Json;
using TrackR.Pages;

namespace TrackR.ViewModel
{
    public partial class LoginPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        private readonly HttpClient _httpClient;

        public LoginPageViewModel()
        {
            _httpClient = new HttpClient();
        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                await Shell.Current.DisplayAlert("Error", "Invalid credentials", "Ok");
                return;
            }

            var dto = new LoginDto
            {
                Username = Username,
                Password = Password
            };

            // result = await _httpClient.PostAsJsonAsync("https://mydomain.com/login", dto);
            var result = new HttpResponseMessage(HttpStatusCode.OK);

            if (!result.IsSuccessStatusCode)
            {
                await Shell.Current.DisplayAlert("Error", "Invalid credentials", "Ok");
                return;
            }

            await Shell.Current.GoToAsync("mainPage");
        }
    }

    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
