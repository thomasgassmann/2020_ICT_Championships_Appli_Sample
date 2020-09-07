using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourCtrl.Models;
using TourCtrl.Properties;

namespace TourCtrl
{
    public partial class TournamentOverview : Form
    {
        private readonly int _tournamentId;
        private Tournament _t;

        public TournamentOverview(int tourmamentId)
        {
            _tournamentId = tourmamentId;
            InitializeComponent();
            this.pictureBox1.Image = Resources.Header;
            LoadTournament();
            LoadFromTournament();
            SetEditDeleteEnabled();

            this.matchUserControl.OnStageAdded += this.MatchUserControl_OnStageAdded;
        }

        private void MatchUserControl_OnStageAdded(object sender, EventArgs e)
        {
            this.LoadMatchInfo();
        }

        private void LoadTournament()
        {
            _t = new TourCtrlContext().Tournament
                .Include(x => x.Game)
                .Include(x => x.ParticipantInTournament)
                .ThenInclude(x => x.Participant)
                .First(x => x.Id == _tournamentId);

            LoadFromTournament();
        }

        private void LoadFromTournament()
        {
            this.lbTournamentTitle.Text = _t.Title;
            this.lbGame.Text = $"Game: {_t.Game.Name}";

            LoadParticipantInfo();
            LoadMatchInfo();
        }

        private void LoadMatchInfo()
        {
            this.btStartTournament.Visible = _t.TournamentState == TournamentState.NotStarted;
            this.matchUserControl.Visible = _t.TournamentState != TournamentState.NotStarted;

            var matches = new TourCtrlContext().Match
                .Include(x => x.Participant1)
                .Include(x => x.Participant2)
                .Include(x => x.WinnerParticipant)
                .Where(x => x.TournamentId == _tournamentId)
                .AsNoTracking()
                .ToList();
            matchUserControl.Matches = matches;
        }

        private void SetEditDeleteEnabled()
        {
            var can = this.listParticipants.SelectedItems.Count == 1 && this.listParticipants.SelectedItems[0].Tag is ParticipantInTournament t;
            this.btRemove.Enabled = can;
            this.btEdit.Enabled = can;
        }

        private void LoadParticipantInfo()
        {
            this.btRemove.Enabled = _t.TournamentState == TournamentState.NotStarted;
            this.btEdit.Enabled = _t.TournamentState == TournamentState.NotStarted;
            this.btAddParticipant.Enabled = _t.TournamentState == TournamentState.NotStarted;
            this.btFillRandom.Enabled = _t.TournamentState == TournamentState.NotStarted;

            this.lbParticipantCount.Text = _t.ParticipantInTournament.Count().ToString();
            this.lbTournamentSizeCount.Text = _t.Size.ToString();
            this.lbParticipantTitle.Text = $"Participants of \"{_t.Title}\"";

            this.listParticipants.Items.Clear();
            foreach (var part in _t.ParticipantInTournament)
            {
                this.listParticipants.Items.Add(new ListViewItem(part.Participant.Name)
                {
                    Tag = part
                });
            }

            if (_t.Size == _t.ParticipantInTournament.Count())
            {
                this.btAddParticipant.Enabled = false;
                this.btFillRandom.Enabled = false;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (this.listParticipants.SelectedItems.Count == 1 && this.listParticipants.SelectedItems[0].Tag is ParticipantInTournament t)
            {
                if (new EditParticipant(t.TournamentId.Value, t).ShowDialog() == DialogResult.OK)
                {
                    this.LoadTournament();
                }
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (this.listParticipants.SelectedItems.Count == 1 && this.listParticipants.SelectedItems[0].Tag is ParticipantInTournament t)
            {
                var ctx = new TourCtrlContext();
                var item = ctx.ParticipantInTournament.Include(x => x.Participant).First(x => x.Id == t.Id);

                if (item.Participant.IsTemporary)
                {
                    ctx.Participant.Remove(item.Participant);
                }

                ctx.ParticipantInTournament.Remove(item);
                ctx.SaveChanges();

                this.LoadTournament();
            }
        }

        private void btFillRandom_Click(object sender, EventArgs e)
        {
            var ctx = new TourCtrlContext();
            var toGen = _t.Size - _t.ParticipantInTournament.Count();
            for (var i = 0; i < toGen; i++)
            {
                ctx.ParticipantInTournament.Add(new ParticipantInTournament
                {
                    TournamentId = this._tournamentId,
                    Participant = new Participant
                    {
                        IsTeam = true,
                        IsTemporary = true,
                        Name = $"Participant #{i + 1}"
                    }
                });
            }

            ctx.SaveChanges();
            this.LoadTournament();
        }

        private void btAddParticipant_Click(object sender, EventArgs e)
        {
            if (new EditParticipant(this._tournamentId, null).ShowDialog() == DialogResult.OK)
            {
                this.LoadTournament();
            }
        }

        private void listParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetEditDeleteEnabled();
        }

        private void btStartTournament_Click(object sender, EventArgs e)
        {
            if (StageLogic.StartTournamnet(_t))
            {
                this.LoadTournament();
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            var matches = new TourCtrlContext().Match.AsNoTracking()
                .Include(x => x.Participant1)
                .Include(x => x.Participant2)
                .Where(x => x.TournamentId == _tournamentId).ToList();
            using (var dialog = new SaveFileDialog())
            {
                dialog.FileName = $"{_t.Title}-{DateTime.Now.Date:yyyyMMdd}.csv";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var streamWriter = new StreamWriter(dialog.FileName))
                    {
                        string Encode(string t)
                        {
                            if (t.Contains(","))
                            {
                                return $"\"{t.Replace("\"", "\"\"")}\"";
                            }

                            return t;
                        }

                        foreach (var match in matches.OrderBy(x => x.Stage).ThenBy(x => x.Order))
                        {
                            var winner = match.WinnerParticipantId == match.Participant1Id
                                ? match.Participant1
                                : (match.WinnerParticipantId == match.Participant2Id
                                    ? match.Participant2
                                    : null);
                            var looser = match.WinnerParticipantId != match.Participant1Id
                                ? match.Participant1
                                : match.Participant2;
                            streamWriter.WriteLine($"{match.Stage + 1},{match.Order + 1},{Encode(winner?.Name ?? "-")},{Encode(looser?.Name ?? "-")}");
                        }
                    }
                }
            }
        }
    }
}
