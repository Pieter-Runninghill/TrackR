using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackR.Models
{
    public class UserData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string HomeLocation { get; set; }
        public string OfficeLocation { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
