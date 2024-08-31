using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TrackR.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        private async Task NavigateToProfileAsync()
        {
            await Shell.Current.GoToAsync("ProfilePage");
        }

        [RelayCommand]
        private async Task NavigateToTripsAsync()
        {
            await Shell.Current.GoToAsync("tripsPage");
        }

        [RelayCommand]
        private async Task NavigateToNewTripAsync()
        {
            await Shell.Current.GoToAsync("NewTripPage");
        }
    }
}
