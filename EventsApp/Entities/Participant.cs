using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApp.Entities
{
    public class Participant
    {
        public int ParticipantId { get; set; }
        public string NomComplet { get; set; }

        // one-to-many
        public Evenement Evenement { get; set; }
    }
}
