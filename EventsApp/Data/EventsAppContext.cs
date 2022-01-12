using EventsApp.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApp.Data
{
    public class EventsAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }
            public DbSet<Evenement> Evenements { get; set; }
            public DbSet<Participant> Participants { get; set; }
            public DbSet<Categorie> Categories { get; set; }
            public DbSet<Organisateur> Organisateurs { get; set; }

    }
}
