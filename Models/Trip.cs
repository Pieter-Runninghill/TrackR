
namespace TrackR.Models
{
    public class Trip
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ClientId { get; set; }

        public DateTime TripDate { get; set; }

        public string StartAddress { get; set; }

        public double StartLongitude { get; set; }

        public double StartLatitude { get; set; }

        public string EndAddress { get; set; }

        public double EndLongitude { get; set; }

        public double EndLatitude { get; set; }

        public float Reimbursabledistance { get; set; }

        public float ReimbursementValue { get; set; }

        public bool IsEligibleForAllowance { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
