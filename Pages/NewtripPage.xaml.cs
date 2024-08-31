using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class NewTripPage : ContentPage
    {
        public NewTripPage(NewTripViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
