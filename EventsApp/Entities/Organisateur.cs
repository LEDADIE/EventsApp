using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApp.Entities
{
    public class Organisateur
    {
        public int OrganisateurId { get; set; }
        public string Nom { get; set; }

        // One-to-One
        public int EvenementRef { get; set; }
        public Evenement Evenement { get; set; }
    }
}
