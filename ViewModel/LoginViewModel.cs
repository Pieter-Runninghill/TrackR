#if ANDROID
using Android.App;
#endif
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Identity.Client;
using System.IdentityModel.Tokens.Jwt;
using TrackR.Helpers;
using TrackR.Services;
using TrackR.Services.Interface;

namespace TrackR.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        private readonly IUserService _userService;
        #if ANDROID
        private Activity _activity;
        #endif


        public LoginViewModel(IUserService userService)
        {
            _userService = userService;
        }

        #if ANDROID
        public void SetActivity(Activity activity)
        {
            _activity = activity;
        }
        #endif

        [RelayCommand]
        private async Task LoginAsync()
        {
            try
            {
                var accounts = await ApiConfig.PublicClientApp.GetAccountsAsync();
                AuthenticationResult result = await ApiConfig.PublicClientApp
                    .AcquireTokenInteractive(ApiConfig.Scopes)
                    .WithAccount(accounts.FirstOrDefault())
                    .WithPrompt(Prompt.SelectAccount)
                    #if ANDROID
                    .WithParentActivityOrWindow(_activity)
                    #endif
                    .ExecuteAsync();

                ApiConfig.AccessToken = result.AccessToken;

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(result.IdToken) as JwtSecurityToken;

                var email = jsonToken.Claims.First(claim => claim.Type == "emails").Value;
                var name = jsonToken.Claims.First(claim => claim.Type == "name").Value;

                var user = await _userService.GetUserByEmail(email);
                if (user == null)
                {
                    // Call create user endpoint
                    // Implement this method in your UserService
                    // await _userService.CreateUser(email, name);
                }

                await Shell.Current.GoToAsync("//MainPage");
            }
            catch (MsalException ex)
            {
                await Shell.Current.DisplayAlert("Authentication failed", ex.Message, "OK");
            }
        }
    }
}
