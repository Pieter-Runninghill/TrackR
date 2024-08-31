using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TrackR.Models;
using TrackR.Services.Interface;

namespace TrackR.ViewModel
{
    public partial class SignUpViewModel : ObservableObject
    {
        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string name;

        private readonly IUserService _userService;

        public SignUpViewModel(IUserService userService)
        {
            _userService = userService;
        }

        [RelayCommand]
        private async Task SignUpAsync()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Name))
            {
                await Shell.Current.DisplayAlert("Error", "All fields are required", "Ok");
                return;
            }

            var newUser = new User { Email = Email, Password = Password, Name = Name, Id = 1 };

            // Mock successful user creation
            var result = new UserCreationResult
            {
                Success = true,
                Message = "Account created successfully",
                User = newUser
            };

            if (result.Success)
            {
                string userJson = JsonSerializer.Serialize(result.User);
                Preferences.Set("CurrentUser", userJson);
                await Shell.Current.GoToAsync("//MainPage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", result.Message, "Ok");
            }
        }
    }

    public struct UserCreationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public User User { get; set; }
    }
}
