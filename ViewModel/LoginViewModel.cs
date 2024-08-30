using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Net;
using System.Net.Http.Json;

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
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid credentials", "Ok");
                return;
            }

            // Additional validation code omitted
            // ...

            var dto = new LoginDto
            {
                Username = Username,
                Password = Password
            };

            // result = await _httpClient.PostAsJsonAsync("https://mydomain.com/login", dto);
            var result = new HttpResponseMessage(HttpStatusCode.OK);

            if (!result.IsSuccessStatusCode)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid credentials", "Ok");
                return;
            }

            await Shell.Current.GoToAsync("homepage");
        }
    }

    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
