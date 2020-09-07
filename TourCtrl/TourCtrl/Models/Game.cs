using System;
using System.Collections.Generic;

namespace TourCtrl.Models
{
    public partial class Game
    {
        public Game()
        {
            Tournament = new HashSet<Tournament>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tournament> Tournament { get; set; }
    }
}
