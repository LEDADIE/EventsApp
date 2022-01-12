﻿// <auto-generated />
using System;
using EventsApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventsApp.Data.Migrations
{
    [DbContext(typeof(EventsAppContext))]
    partial class EventsAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventsApp.Entities.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EventsApp.Entities.Evenement", b =>
                {
                    b.Property<int>("EvenementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateHeure")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Date de l'heure de l'evenement");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EvenementId");

                    b.ToTable("Evenements");
                });

            modelBuilder.Entity("EventsApp.Entities.Organisateur", b =>
                {
                    b.Property<int>("OrganisateurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EvenementRef")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganisateurId");

                    b.HasIndex("EvenementRef")
                        .IsUnique();

                    b.ToTable("Organisateurs");
                });

            modelBuilder.Entity("EventsApp.Entities.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EvenementId")
                        .HasColumnType("int");

                    b.Property<string>("NomComplet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParticipantId");

                    b.HasIndex("EvenementId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("EventsApp.Entities.Organisateur", b =>
                {
                    b.HasOne("EventsApp.Entities.Evenement", "Evenement")
                        .WithOne("Organisateur")
                        .HasForeignKey("EventsApp.Entities.Organisateur", "EvenementRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evenement");
                });

            modelBuilder.Entity("EventsApp.Entities.Participant", b =>
                {
                    b.HasOne("EventsApp.Entities.Evenement", "Evenement")
                        .WithMany()
                        .HasForeignKey("EvenementId");

                    b.Navigation("Evenement");
                });

            modelBuilder.Entity("EventsApp.Entities.Evenement", b =>
                {
                    b.Navigation("Organisateur");
                });
#pragma warning restore 612, 618
        }
    }
}
