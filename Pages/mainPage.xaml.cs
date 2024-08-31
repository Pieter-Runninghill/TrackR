using Microsoft.Maui.Controls;
using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class mainPage : ContentPage
    {
        public mainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private async void OnProfileButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnTripsButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new tripsPage());
        }

        //private async void OnNewTripButtonClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new NewTripPage());
        //}
    }
}
