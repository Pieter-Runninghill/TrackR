using Microsoft.Identity.Client;

namespace TrackR.Helpers
{
    public static class ApiConfig
    {
        public static string BaseAddress { get; set; } = "https://c9aa-41-150-248-158.ngrok-free.app/api/";

        public const string ClientId = "d2a2d240-3bca-4d27-952e-aa2cf85bc198";
        public const string TenantName = "runninghillb2c";
        public const string TenantId = "9ef6a126-a4b8-451a-a754-d0decc4db7b2";
        public const string SignUpSignInPolicyId = "B2C_1_TrackR";
        public static readonly string[] Scopes = { "openid", "profile", "email" };
        public const string AuthorityBase = "https://runninghillb2c.b2clogin.com/tfp/runninghillb2c.onmicrosoft.com/";
        public static string AccessToken { get; set; }


        public static IPublicClientApplication PublicClientApp { get; private set; }

        static ApiConfig()
        {
            InitializePublicClientApplication();
        }

        private static void InitializePublicClientApplication()
        {
            PublicClientApp = PublicClientApplicationBuilder
                .Create(ClientId)
                .WithB2CAuthority($"{AuthorityBase}{SignUpSignInPolicyId}")
                .WithRedirectUri($"msal{ClientId}://auth")
                .Build();
        }
    }
}
