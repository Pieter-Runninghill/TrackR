using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Text.Json;
using TrackR.Models;
using TrackR.Pages;
using TrackR.Services.Interface;

namespace TrackR.ViewModel
{
    public partial class TripsViewModel : ObservableObject
    {
        private readonly ITripService _tripService;

        [ObservableProperty]
        private ObservableCollection<Trip> trips;

        [ObservableProperty]
        private User currentUser;

        public TripsViewModel(ITripService tripService)
        {
            _tripService = tripService;
            LoadUserAndTrips();
        }

        private async void LoadUserAndTrips()
        {
            var userJson = Preferences.Get("CurrentUser", "");
            if (!string.IsNullOrEmpty(userJson))
            {
                CurrentUser = JsonSerializer.Deserialize<User>(userJson);
                await LoadTripsAsync();
            }
        }

        [RelayCommand]
        private async Task LoadTripsAsync()
        {
            if (CurrentUser != null)
            {
                var userTrips = await _tripService.GetAllTripsByUser(CurrentUser.Id);
                Trips = new ObservableCollection<Trip>(userTrips ?? new List<Trip>());
            }
            else
            {
                Trips = new ObservableCollection<Trip>();
            }
        }

        [RelayCommand]
        private async Task AddTripAsync()
        {
            // Navigate to Add Trip page or show Add Trip dialog
            await Shell.Current.GoToAsync(nameof(NewTripPage));
        }

        [RelayCommand]
        private async Task ViewTripDetailsAsync(Trip trip)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "TripId", trip.Id }
            };
            await Shell.Current.GoToAsync(nameof(TripDetailsPage), navigationParameter);
        }
    }
}
