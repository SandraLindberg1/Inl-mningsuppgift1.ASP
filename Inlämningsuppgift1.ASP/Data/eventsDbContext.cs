using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift1.ASP.Models;

namespace Inlämningsuppgift1.ASP.Data
{
    public class eventsDbContext : DbContext
    {
        public eventsDbContext (DbContextOptions<eventsDbContext> options)
            : base(options)
        {
        
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>().ToTable("Attendee");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Organizer>().ToTable("Organizer");
        }
    }
}
