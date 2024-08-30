using System;
using Microsoft.Maui.Controls;

namespace TrackR.Pages
{
    public partial class NewtripPage : ContentPage
    {
        public NewtripPage()
        {
            InitializeComponent();
        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            
            double.TryParse(DistanceToOfficeEntry.Text, out double distanceToOffice);
            double.TryParse(DistanceToClientEntry.Text, out double distanceToClient);
            double.TryParse(DistanceDifferenceEntry.Text, out double distanceDifference);
            double.TryParse(EligibleAllowanceEntry.Text, out double eligibleAllowance);
            double.TryParse(ReimbursementValueEntry.Text, out double reimbursementValue);

        }
    }
}
