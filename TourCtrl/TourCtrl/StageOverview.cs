using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TourCtrl.Models;

namespace TourCtrl
{
    public partial class StageOverview : UserControl
    {
        private List<Match> _matches = new List<Match>();

        public StageOverview()
        {
            InitializeComponent();
        }

        public event EventHandler OnStageAdded;

        [Category("Data"), Description("MatchesInStage")]
        public List<Match> MatchesInStage
        {
            set
            {
                _matches = value.OrderBy(x => x.Order).ToList();

                RenderStage();
            }
        }

        private void RenderStage()
        {
            lbStage.Text = $"Stage {_matches[0].Stage + 1}";
            lbParticipants.Text = $"{_matches.SelectMany(x => new[] { x.Participant1Id, x.Participant2Id }).Where(x => x != null).Distinct().Count()} participants";
            lbMatches.Text = $"{_matches.Count} Matches";

            flowLayoutPanel.AutoScroll = true;
            foreach (var match in _matches)
            {
                var st = new StageItem
                {
                    Match = match,
                    AutoSize = true
                };

                st.MinimumSize = new System.Drawing.Size(st.Size.Width, st.Size.Height);
                st.OnNewStageAdded += this.St_OnNewStageAdded;
                this.flowLayoutPanel.Controls.Add(st);
            }
        }

        private void St_OnNewStageAdded(object sender, System.EventArgs e)
        {
            this.OnStageAdded.Invoke(sender, e);
        }
    }
}
