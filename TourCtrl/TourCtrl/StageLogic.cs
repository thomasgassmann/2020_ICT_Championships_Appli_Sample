using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using TourCtrl.Models;

namespace TourCtrl
{
    public static class StageLogic
    {
        public static bool StartTournamnet(Tournament t)
        {
            if (t.ParticipantInTournament.Count() != t.Size)
            {
                MessageBox.Show("Need cool size of many");
                return false;
            }

            var ctx = new TourCtrlContext();

            var loaded = ctx.Tournament.Find(t.Id);
            loaded.TournamentState = TournamentState.Started;

            ctx.SaveChanges();

            CreateStage(t.Id, 0);

            return true;
        }

        public static void CreateStage(int tournament, int stage)
        {
            var ctx = new TourCtrlContext();

            var participants = stage == 0
                ? ctx.ParticipantInTournament.Include(x => x.ParticipantId).Where(x => x.TournamentId == tournament).Select(x => x.Participant)
                : ctx.Match.Include(x => x.WinnerParticipant).Where(x => x.Stage == stage - 1 && x.TournamentId == tournament).Select(x => x.WinnerParticipant);

            var random = new Random();
            var all = participants.ToList().OrderBy(x => random.Next()).ToList();

            var newMatches = new List<Match>();
            var i = 0;
            while (all.Count > 0)
            {
                var nMatch = new Match
                {
                    TournamentId = tournament,
                    Stage = stage,
                    Order = i++
                };
                newMatches.Add(nMatch);

                if (all.Count >= 2)
                {
                    nMatch.Participant1Id = all[0].Id;
                    nMatch.Participant2Id = all[1].Id;
                    all.RemoveAt(0);
                    all.RemoveAt(0);
                }
                else
                {
                    nMatch.Participant1Id = all[0].Id;
                    nMatch.WinnerParticipantId = all[0].Id;
                    all.RemoveAt(0);
                }
            }

            ctx.Match.AddRange(newMatches);
            ctx.SaveChanges();
        }
    }
}
