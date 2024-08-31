using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using TrackR.Pages;
using TrackR.Services.Interface;

namespace TrackR.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;

        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;

        public LoginViewModel(IUserService userService)
        {
            _httpClient = new HttpClient();
            _userService = userService;

        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            bool answer = await Shell.Current.DisplayAlert("Error", "Invalid credentials", "Try Again", "Sign Up");
            if (!answer)
            {
                await Shell.Current.GoToAsync("SignUpPage");
            }

            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                await Shell.Current.DisplayAlert("Error", "Invalid credentials", "Ok");
                return;
            }

            var dto = new LoginDto
            {
                Email = Email,
                Password = Password
            };

            var user = await _userService.GetUserByEmail(Email);

            //ye
            if (user != null)
            {
                user.Password = Password;
            }

            if (user != null && user.Password == Password)
            {
                string userJson = JsonSerializer.Serialize(user);
                Preferences.Set("CurrentUser", userJson);

                await Shell.Current.GoToAsync("MainPage");
            }
            else
            {
                bool answer2 = await Shell.Current.DisplayAlert("Error", "Invalid credentials", "Try Again", "Sign Up");
                if (!answer2)
                {
                    await Shell.Current.GoToAsync("SignUpPage");
                }
            }
            var result = new HttpResponseMessage(HttpStatusCode.OK);
        }
    }

    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
