using System;
using System.Collections.Generic;

namespace TourCtrl.Models
{
    public partial class Tournament
    {
        public Tournament()
        {
            Match = new HashSet<Match>();
            ParticipantInTournament = new HashSet<ParticipantInTournament>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? GameId { get; set; }
        public int? Size { get; set; }
        public int? WinnerParticipantId { get; set; }
        public int TournamentState { get; set; }

        public virtual Game Game { get; set; }
        public virtual Participant WinnerParticipant { get; set; }
        public virtual ICollection<Match> Match { get; set; }
        public virtual ICollection<ParticipantInTournament> ParticipantInTournament { get; set; }
    }
}
