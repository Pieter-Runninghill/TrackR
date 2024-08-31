﻿using TrackR.Pages;

namespace TrackR
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(tripsPage), typeof(tripsPage));
            Routing.RegisterRoute(nameof(mainPage), typeof(mainPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        }
    }
}