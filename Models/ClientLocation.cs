﻿
namespace TrackR.Models
{
    public class ClientLocation
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public string ClientLocationName { get; set; }

        public string ClientAddress { get; set; }

        public double ClientLatitude { get; set; }

        public double clientLongitude { get; set; }
    }
}
