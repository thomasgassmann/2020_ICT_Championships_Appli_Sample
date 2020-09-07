using System;
using System.Collections.Generic;

namespace TourCtrl.Models
{
    public partial class ParticipantInTournament
    {
        public int Id { get; set; }
        public int? TournamentId { get; set; }
        public int? ParticipantId { get; set; }

        public virtual Participant Participant { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
