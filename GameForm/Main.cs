using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppForConcentration.GameForm;

namespace AppForConcentration
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void PlayButtonClick(object sender, EventArgs e)
        {
            var gameForm = new GameForm.Game();
            gameForm.Show();
            Hide();
        }
    }
}
