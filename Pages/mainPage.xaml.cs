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
    }
}
