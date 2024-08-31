
namespace TrackR.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string HomeAddress { get; set; }

        public double HomeLongitude { get; set; }

        public double HomeLatitude { get; set; }

        public string OfficeAddress { get; set; }

        public double OfficeLongitude { get; set; }

        public double OfficeLatitude { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
