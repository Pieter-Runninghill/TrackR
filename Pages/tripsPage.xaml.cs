using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class TripsPage : ContentPage
    {
        public TripsPage(TripsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
