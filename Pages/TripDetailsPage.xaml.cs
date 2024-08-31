using TrackR.ViewModel;

namespace TrackR.Pages
{
	public partial class TripDetailsPage : ContentPage
	{
		public TripDetailsPage(TripDetailsViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = viewModel;
		}
	}
}