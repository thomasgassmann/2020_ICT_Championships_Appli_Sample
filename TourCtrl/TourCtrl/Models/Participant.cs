using System;
using System.Collections.Generic;

namespace TourCtrl.Models
{
    public partial class Participant
    {
        public Participant()
        {
            MatchParticipant1 = new HashSet<Match>();
            MatchParticipant2 = new HashSet<Match>();
            MatchWinnerParticipant = new HashSet<Match>();
            ParticipantInTournament = new HashSet<ParticipantInTournament>();
            Tournament = new HashSet<Tournament>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTemporary { get; set; }
        public bool IsTeam { get; set; }

        public virtual ICollection<Match> MatchParticipant1 { get; set; }
        public virtual ICollection<Match> MatchParticipant2 { get; set; }
        public virtual ICollection<Match> MatchWinnerParticipant { get; set; }
        public virtual ICollection<ParticipantInTournament> ParticipantInTournament { get; set; }
        public virtual ICollection<Tournament> Tournament { get; set; }
    }
}
