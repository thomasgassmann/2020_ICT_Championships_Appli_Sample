using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TourCtrl.Models;

namespace TourCtrl
{
    public partial class MatchUserControl : UserControl
    {
        private List<Match> _matches = new List<Match>();

        public MatchUserControl()
        {
            InitializeComponent();
            RenderStages();
        }

        public event EventHandler OnStageAdded;

        [Category("Data"), Description("Matches")]
        public List<Match> Matches
        {
            set
            {
                _matches = value;
                RenderStages();
            }
        }

        private void RenderStages()
        {
            this.tabControl.TabPages.Clear();
            foreach (var group in this._matches.GroupBy(x => x.Stage))
            {
                var page = new TabPage($"Stage {group.Key}");
                var g = new StageOverview
                {
                    MatchesInStage = group.ToList()
                };
                page.Controls.Add(g);

                g.OnStageAdded += this.G_OnStageAdded;

                this.tabControl.TabPages.Add(page);
            }
        }

        private void G_OnStageAdded(object sender, EventArgs e)
        {
            this.OnStageAdded.Invoke(sender, e);
        }
    }
}
