using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApp.Entities
{
    public class Evenement
    {
        public int EvenementId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Titre { get; set; }

        public string Description { get; set; }

        [Comment("Date de l'heure de l'evenement")]
        public string DateHeure { get; set; }
    }
}
