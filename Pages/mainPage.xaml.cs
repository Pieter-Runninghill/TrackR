using Microsoft.Maui.Controls;
using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
