using Microsoft.Extensions.Logging;
using TrackR.Pages;
using TrackR.ViewModel;
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

            // Register Views
            builder.Services.AddTransient<NewTripPage>();
            builder.Services.AddTransient<TripsPage>();
            builder.Services.AddTransient<mainPage>();
            builder.Services.AddTransient<TripDetailsPage>();
            builder.Services.AddTransient<ProfilePage>();
            builder.Services.AddTransient<LoginPage>();


            // Register ViewModels
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<NewTripViewModel>();
            builder.Services.AddTransient<TripsViewModel>();
            builder.Services.AddTransient<TripDetailsViewModel>();
            builder.Services.AddTransient<ProfileViewModel>();
            builder.Services.AddTransient<LoginPageViewModel>();


            return builder.Build();
        }
    }
}
