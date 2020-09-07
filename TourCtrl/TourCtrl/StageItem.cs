using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TourCtrl.Models;

namespace TourCtrl
{
    public partial class StageItem : UserControl
    {
        private Match _match;

        public StageItem()
        {
            InitializeComponent();
        }

        public event EventHandler OnNewStageAdded;

        [Category("Data"), Description("Match")]
        public Match Match
        {
            set
            {
                _match = value;
                RenderMatch();
            }
        }

        private void RenderMatch()
        {
            this.btLoose1.Visible = true;
            this.btWinPart1.Visible = true;
            this.btWinPart2.Visible = true;
            this.btLoose2.Visible = true;
            this.lbState1.Visible = true;
            this.lbState2.Visible = true;

            this.groupBox.Text = $"Match {_match.Stage + 1}{_match.Order + 1}";
            this.lbParticipant1.Text = _match.Participant1.Name;
            this.lbParticipant2.Text = _match.Participant2?.Name ?? "-";
            if (_match.WinnerParticipantId.HasValue)
            {
                this.btLoose1.Visible = false;
                this.btWinPart1.Visible = false;
                this.btWinPart2.Visible = false;
                this.btLoose2.Visible = false;

                SetWinState(lbState1, _match.WinnerParticipantId == _match.Participant1Id);
                SetWinState(lbState2, _match.WinnerParticipantId == _match.Participant2Id);
            }
            else
            {
                this.lbState1.Visible = false;
                this.lbState2.Visible = false;
            }

            if (!_match.Participant2Id.HasValue)
            {
                this.lbState2.Visible = false;
            }
        }

        private void SetWinState(Label label, bool didWin)
        {
            label.Text = didWin ? "W" : "L";
            label.ForeColor = didWin ? Color.Green : Color.Red;
        }

        private void MakeWin(bool part1)
        {
            var ctx = new TourCtrlContext();
            var match = ctx.Match.Find(_match.Id);
            match.WinnerParticipantId = part1 ? match.Participant1Id : match.Participant2Id;

            ctx.SaveChanges();

            if (ctx.Match.Where(x => x.TournamentId == match.TournamentId && x.Stage == match.Stage).All(x => x.WinnerParticipantId.HasValue))
            {
                if (StageLogic.CreateStage(match.TournamentId.Value, match.Stage + 1))
                {
                    this.OnNewStageAdded.Invoke(this, new EventArgs());
                }
            }

            _match.WinnerParticipantId = match.WinnerParticipantId;
            RenderMatch();
        }

        private void btWinPart2_Click(object sender, System.EventArgs e)
        {
            MakeWin(false);
        }

        private void btLoose2_Click(object sender, System.EventArgs e)
        {
            MakeWin(true);
        }

        private void btLoose1_Click(object sender, System.EventArgs e)
        {
            MakeWin(false);
        }

        private void btWinPart1_Click(object sender, System.EventArgs e)
        {
            MakeWin(true);
        }
    }
}
