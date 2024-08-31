using Microsoft.Maui.Controls;
using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(ProfileViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
