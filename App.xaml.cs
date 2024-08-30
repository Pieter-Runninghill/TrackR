using Microsoft.Maui.Controls;
using TrackR.Pages;

namespace TrackR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage());

            MainPage = new LoginPage();
        }
    }
}
