using TrackR.Pages;

namespace TrackR
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TripsPage), typeof(TripsPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(TripDetailsPage), typeof(TripDetailsPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(NewTripPage), typeof(NewTripPage));
            Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));

        }
    }
}