using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TrackR.Models;
using TrackR.Services.Interface;
using static Java.Util.Jar.Attributes;

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

            var newUser = new User { Email = Email, Password = Password, Name = Name };

            // Mock the CreateUser response using a struct
            var result = new UserCreationResult
            {
                Success = true,
                Message = "Account created successfully",
                UserId = Guid.NewGuid().ToString()
            };
            //ToDo
            //var result = await _userService.CreateUser(newUser);

            if (result.Success)
            {
                await Shell.Current.DisplayAlert("Success", "Account created successfully", "Ok");
                await Shell.Current.GoToAsync("//MainPage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", result.Message, "Ok");
            }
        }

        public struct UserCreationResult
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public string UserId { get; set; }
        }
    }
}
