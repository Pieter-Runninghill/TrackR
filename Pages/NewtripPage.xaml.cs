using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;
using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class NewtripPage : ContentPage
    {
        public NewtripPage(NewTripViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            
            //double.TryParse(DistanceToOfficeEntry.Text, out double distanceToOffice);
            //double.TryParse(DistanceToClientEntry.Text, out double distanceToClient);
            //double.TryParse(DistanceDifferenceEntry.Text, out double distanceDifference);
            //double.TryParse(EligibleAllowanceEntry.Text, out double eligibleAllowance);
            //double.TryParse(ReimbursementValueEntry.Text, out double reimbursementValue);

        }
    }
}
