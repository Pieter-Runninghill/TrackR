using System.Net.Http;
using TrackR.Services.Interface;

namespace TrackR
{
    public partial class MainPage : ContentPage
    {
        private readonly IUserService _userService;

        public MainPage(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void OnCreateAccountClicked(object sender, EventArgs e)
        {
            var response = await _userService.GetUserByEmail("pieterc@runninghill.co.za");
        }

    }

}
