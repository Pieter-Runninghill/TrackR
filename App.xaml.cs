using Microsoft.Maui.Controls;
using TrackR.Pages;

namespace TrackR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); 

           
            MainPage = new NavigationPage(new LoginPage()); 
         
        }
    }
}
