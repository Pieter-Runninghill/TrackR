using CommunityToolkit.Mvvm.ComponentModel;

namespace TrackR.ViewModel
{
    public partial class ProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string homeLocation;

        [ObservableProperty]
        private string workAddress;

        public ProfileViewModel()
        {
            
        }
    }
}
