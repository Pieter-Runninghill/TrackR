using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace TrackR.ViewModel
{
    public partial class TripsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string clientName;

        [ObservableProperty]
        private string date;

        [ObservableProperty]
        private ObservableCollection<Trip> trips;


        public TripsViewModel()
        {
           
            Trips = new ObservableCollection<Trip>
            {
                new Trip { ClientName = "Client A", Date = "2024-08-30" },
                new Trip { ClientName = "Client B", Date = "2024-08-31" },
                
            };
        }

        [RelayCommand]
        private async Task NavigateToDetailsAsync(Trip selectedTrip)
        {
            if (selectedTrip == null)
                return;

            await Shell.Current.GoToAsync("detailsPage", new Dictionary<string, object>
            {
                { "SelectedTrip", selectedTrip }
            });
        }
    }

    public class Trip
    {
        public string ClientName { get; set; }
        public string Date { get; set; }
        
    }
}
