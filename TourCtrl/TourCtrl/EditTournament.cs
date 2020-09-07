using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TourCtrl.Models;

namespace TourCtrl
{
    public partial class EditTournament : Form
    {
        public EditTournament()
        {
            InitializeComponent();
            ValidateButton();

            this.cbGame.Items.AddRange(new TourCtrlContext().Game.AsNoTracking().ToArray());
        }

        private void tbGame_TextChanged(object sender, EventArgs e)
        {
            ValidateButton();
        }

        private void cbGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateButton();
        }

        private void ValidateButton()
        {
            this.lbErrorMessage.Text = string.Empty;
            this.btCreate.Enabled = this.tbGame.Text.Length > 0 && this.cbGame.SelectedItem != null;
            if (this.tbGame.Text.Length == 0)
            {
                this.lbErrorMessage.Text += "Need some more title stuff.";
            }

            if (this.cbGame.SelectedItem == null)
            {
                this.lbErrorMessage.Text += "Also need game stuff.";
            }

            if (this.btCreate.Enabled)
            {
                this.lbErrorMessage.Text = "";
            }
        }

        private void EditTournament_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                var ctx = new TourCtrlContext();
                ctx.Tournament.Add(new Tournament
                {
                    GameId = (this.cbGame.SelectedItem as Game).Id,
                    Title = this.tbGame.Text,
                    Size = (int)this.numSize.Value
                });

                ctx.SaveChanges();
            }
        }
    }
}
