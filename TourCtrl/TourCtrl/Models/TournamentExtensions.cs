using System;
using System.Collections.Generic;
using System.Text;

namespace TourCtrl.Models
{
    public partial class Tournament
    {
        public string GetWinner()
        {
            if (this.WinnerParticipantId.HasValue)
            {
                return this.WinnerParticipant.Name;
            }

            return "undecided";
        }
    }
}
