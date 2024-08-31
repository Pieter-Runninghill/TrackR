
namespace TrackR.Models
{
    public class Client
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ClientLocationId { get; set; }

        public string ClientName { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
