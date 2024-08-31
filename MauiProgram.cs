using Microsoft.Extensions.Logging;
using TrackR.Pages;
using TrackR.ViewModel;

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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Register Views
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<NewTripPage>();
            builder.Services.AddTransient<TripsPage>();
            builder.Services.AddTransient<TripDetailsPage>();
            builder.Services.AddTransient<ProfilePage>();

            // Register ViewModels
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<NewTripViewModel>();
            builder.Services.AddTransient<TripsPage>();
            builder.Services.AddTransient<TripDetailsPage>();
            builder.Services.AddTransient<ProfilePage>();
            return builder.Build();
        }
    }
}
