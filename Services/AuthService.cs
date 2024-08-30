using Microsoft.Identity.Client;
namespace TrackR.Services
{
    public class AuthService
    {
        private readonly IPublicClientApplication _pca;
        private readonly string[] Scopes;

        public AuthService()
        {
            Scopes = new string[]
            {
                "User.Read",             // Read the user's profile information
                "email",                 // Access the user's primary email address
                "profile",               // Read the user's basic profile information
                "openid"                 // Sign-in and read the user's ID token
            };
            _pca = PublicClientApplicationBuilder.Create("Azure-AD-Client-ID")
                    .WithAuthority(AadAuthorityAudience.AzureAdAndPersonalMicrosoftAccount)
                    .WithRedirectUri("Redirect-URI")
                    .Build();
        }

        public async Task<AuthenticationResult> SignInAsync()
        {
            var accounts = await _pca.GetAccountsAsync();
            AuthenticationResult result;
            try
            {
                result = await _pca.AcquireTokenSilent(Scopes, accounts.FirstOrDefault())
                                   .ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                result = await _pca.AcquireTokenInteractive(Scopes)
                                   .ExecuteAsync();
            }
            return result;
        }
    }
}

