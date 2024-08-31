using Microsoft.Maui.Controls;
using TrackR.Pages;
using TrackR.ViewModel;

namespace TrackR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var loginViewModel = new LoginPageViewModel();
            MainPage = new NavigationPage(new LoginPage(loginViewModel));
        }
    }
}
