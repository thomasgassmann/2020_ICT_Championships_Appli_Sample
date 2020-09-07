using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public TournamentOverview(int tourmamentId)
        {
            _tournamentId = tourmamentId;
            InitializeComponent();
            this.pictureBox1.Image = Resources.Header;
            LoadFromTournament();
        }

        private void LoadFromTournament()
        {
            var t = new TourCtrlContext().Tournament
                .Include(x => x.Game)
                .First(x => x.Id == _tournamentId);
            this.lbTournamentTitle.Text = t.Title;
            this.lbGame.Text = $"Game: {t.Game.Name}";
        }
    }
}
