using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Net;
using System.Net.Http.Json;

namespace TrackR.ViewModel
{
    public partial class LoginPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _Username;

        [ObservableProperty]
        private string _Password;

        private readonly HttpClient _httpClient;

        public LoginPageViewModel()
        {
            _httpClient = new HttpClient();
        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            if (string.IsNullOrWhiteSpace(_Username) || string.IsNullOrWhiteSpace(_Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid credentials", "Ok");
                return;
            }

            // Additional validation code omitted
            // ...

            var dto = new LoginDto
            {
                Username = _Username,
                Password = _Password
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
