using TrackR.Pages;

namespace TrackR
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TripsPage), typeof(TripsPage));
            Routing.RegisterRoute(nameof(mainPage), typeof(mainPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        }
    }
}