using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForConcentration.Game
{
    class Player
    {
        public int Score { get; set; }
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
    }
}
