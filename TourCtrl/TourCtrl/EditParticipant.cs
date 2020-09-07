using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourCtrl.Models;

namespace TourCtrl
{
    public partial class EditParticipant : Form
    {
        private readonly int? id;
        private readonly int _tid;

        public EditParticipant(int tournamentId, int? participantInTournamentId)
        {
            _tid = tournamentId;
            id = participantInTournamentId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private (bool, string) IsValid()
        {
            var r = new StringBuilder();
            if (string.IsNullOrEmpty(this.tbName.Text))
            {
                r.Append("Need name mami. ");
            }    

            if (!this.rbPlayer.Checked && !this.rbTeam.Checked)
            {
                r.Append("Need type pls. ");
            }

            return (r.Length == 0, r.ToString());
        }

        private void EditParticipant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                var (valid, message) = IsValid();
                if (!valid)
                {
                    this.lbError.Text = message;
                    e.Cancel = true;
                    return;
                }

                var ctx = new TourCtrlContext();
                ParticipantInTournament t;
                if (id.HasValue)
                {
                    t = ctx.ParticipantInTournament.Include(x => x.Participant).First(x => x.Id == id.Value);
                }
                else
                {
                    t = new ParticipantInTournament
                    {
                        Participant = new Participant(),
                        TournamentId = _tid
                    };
                    ctx.ParticipantInTournament.Add(t);
                }

                t.Participant.IsTemporary = this.cbTemporary.Checked;
                t.Participant.IsTeam = this.rbTeam.Checked;
                t.Participant.Name = this.tbName.Text;

                ctx.SaveChanges();
            }
        }
    }
}
