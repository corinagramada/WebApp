using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Models
{
    public class VolunteersEventsAppContext : DbContext
    {
        public VolunteersEventsAppContext (DbContextOptions<VolunteersEventsAppContext> options)
            : base(options)
        {
        }

        public DbSet<VolunteersEventsApp.Models.Event> Event { get; set; }

        public DbSet<VolunteersEventsApp.Models.Volunteer> Volunteer { get; set; }
    }
}
