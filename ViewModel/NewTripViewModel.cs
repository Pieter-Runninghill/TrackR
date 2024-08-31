using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TrackR.ViewModel
{
    public partial class NewTripViewModel : ObservableObject
    {
        [ObservableProperty]
        private string startLocation;

        [ObservableProperty]
        private string destination;

        [ObservableProperty]
        private string routes;

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

        public NewTripViewModel()
        {
            
        }

        [RelayCommand]
        private void Submit()
        {
           
        }
    }
}
