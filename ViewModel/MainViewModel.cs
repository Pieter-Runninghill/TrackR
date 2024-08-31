using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TrackR.Pages;

namespace TrackR.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        private async Task NavigateToProfileAsync()
        {
            await Shell.Current.GoToAsync(nameof(ProfilePage));
        }

        [RelayCommand]
        private async Task NavigateToTripsAsync()
        {
            await Shell.Current.GoToAsync(nameof(TripsPage));
        }

        [RelayCommand]
        private async Task NavigateToNewTripAsync()
        {
            await Shell.Current.GoToAsync(nameof(NewTripPage));
        }
    }
}
