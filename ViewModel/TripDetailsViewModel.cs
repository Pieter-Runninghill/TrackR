using CommunityToolkit.Mvvm.ComponentModel;

namespace TrackR.ViewModel
{
    public partial class TripDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string clientName;

        [ObservableProperty]
        private string date;

        [ObservableProperty]
        private double distanceToOffice;

        [ObservableProperty]
        private double distanceToClient;

        [ObservableProperty]
        private double distanceDifference;

        [ObservableProperty]
        private double eligibleAllowance;

        [ObservableProperty]
        private double reimbursementValue;

        public TripDetailsViewModel()
        {
           
        }
    }
}
