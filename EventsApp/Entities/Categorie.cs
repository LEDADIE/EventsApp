using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApp.Entities
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string Nom { get; set; }

        // many-to-many
        public ICollection<Evenement> Evenements { get; set; }
    }
}
