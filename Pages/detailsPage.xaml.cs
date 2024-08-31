using System;
using Microsoft.Maui.Controls;

namespace TrackR.Pages
{
    public partial class detailsPage : ContentPage
    {
        public detailsPage(string clientName, DateTime date)
        {
            InitializeComponent();
            ClientNameLabel.Text = clientName;
            DateLabel.Text = date.ToString("MMMM dd, yyyy");
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
