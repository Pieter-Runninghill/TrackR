using Microsoft.Maui.Controls;
using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class tripsPage : ContentPage
    {
        public tripsPage(TripsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }



        private  void OnDetailsButtonClicked(object sender, EventArgs e)
        {
            
            //Navigation.PushAsync(new DetailsPage());
        }
    }
}
