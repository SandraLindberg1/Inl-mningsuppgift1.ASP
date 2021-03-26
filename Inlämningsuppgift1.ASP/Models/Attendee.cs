using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.ASP.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; } //Primary Key (PK)
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
    }
}
