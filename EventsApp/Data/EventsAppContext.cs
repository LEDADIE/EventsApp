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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // API Fluent
            
            //one to one
            modelBuilder.Entity<Evenement>()
                .HasOne(ev => ev.Organisateur)
                .WithOne(o => o.Evenement)
                .HasForeignKey<Organisateur>(o => o.EvenementRef);

            // one-to-many
            modelBuilder.Entity<Evenement>()
                .HasMany(ev => ev.Participants)
                .WithOne(p => p.Evenement)
                .OnDelete(DeleteBehavior.Cascade); // Autoriser la suppression en cascade

            // many-to-many
            modelBuilder.Entity<Evenement>()
                .HasMany(c => c.Categories)
                .WithMany(ev => ev.Evenements);
        }

        public DbSet<Evenement> Evenements { get; set; }
            public DbSet<Participant> Participants { get; set; }
            public DbSet<Categorie> Categories { get; set; }
            public DbSet<Organisateur> Organisateurs { get; set; }

    }
}
