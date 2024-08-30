using Microsoft.Maui.Controls;

namespace TrackR.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnProfileButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnTripsButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new tripsPage());
        }

        //private async void OnNewTripButtonClicked(object sender, EventArgs e)
        //{

        //    await Navigation.PushAsync(new NewtripPage());
        //}
    }
}
