using Microsoft.Extensions.Logging;
using TrackR.Services;
using TrackR.Services.Interface;
using System.Net.Http;

namespace TrackR
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddHttpClient();

            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<ITripService, TripService>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
