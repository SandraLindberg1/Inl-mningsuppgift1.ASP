using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.ASP.Models
{
    public class Organizer
    {
        public int OrganizerID { get; set; } //Primary Key (PK)
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
