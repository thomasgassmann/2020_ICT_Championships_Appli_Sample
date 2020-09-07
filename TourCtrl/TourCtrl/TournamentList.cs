using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TourCtrl.Models;
using TourCtrl.Properties;

namespace TourCtrl
{
    public partial class TournamentList : Form
    {
        public TournamentList()
        {
            InitializeComponent();
            LoadTournaments();
            ValidateViewButtons();
            this.pictureBox1.Image = Resources.Header;
        }

        private void LoadTournaments()
        {
            this.listTournaments.Items.Clear();
            var items = new TourCtrlContext().Tournament.AsNoTracking().Include(x => x.Game).Include(x => x.WinnerParticipant).ToList();

            foreach (var item in items)
            {
                var lvi = new ListViewItem(item.Title);
                lvi.SubItems.Add(item.Game.Name);
                lvi.SubItems.Add(item.GetWinner());

                lvi.Tag = item;

                this.listTournaments.Items.Add(lvi);
            }
        }

        private void btView_Click(object sender, EventArgs e)
        {
            if (this.listTournaments.SelectedItems.Count == 1 && this.listTournaments.SelectedItems[0].Tag is Tournament t)
            {
                new TournamentOverview(t.Id).ShowDialog();
            }
        }

        private void ValidateViewButtons()
        {
            this.btView.Enabled = this.listTournaments.SelectedItems.Count == 1;
        }

        private void listTournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateViewButtons();
        }

        private void btAddTournament_Click(object sender, EventArgs e)
        {
            if (new EditTournament().ShowDialog() == DialogResult.OK)
            {
                this.LoadTournaments();
            }
        }
    }
}
