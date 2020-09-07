using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourCtrl.Models;

namespace TourCtrl
{
    public partial class TournamentList : Form
    {
        public TournamentList()
        {
            InitializeComponent();
            LoadTournaments();
            ValidateViewButtons();
        }

        private void LoadTournaments()
        {
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
                new TournamentOverview().ShowDialog();
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
