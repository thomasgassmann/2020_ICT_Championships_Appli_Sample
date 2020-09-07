using System;
using System.Collections.Generic;

namespace TourCtrl.Models
{
    public partial class Match
    {
        public int Id { get; set; }
        public int? TournamentId { get; set; }
        public int? Participant1Id { get; set; }
        public int? Participant2Id { get; set; }
        public int Stage { get; set; }
        public int Order { get; set; }
        public int? WinnerParticipantId { get; set; }

        public virtual Participant Participant1 { get; set; }
        public virtual Participant Participant2 { get; set; }
        public virtual Tournament Tournament { get; set; }
        public virtual Participant WinnerParticipant { get; set; }
    }
}
