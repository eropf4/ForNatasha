using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppForConcentration.Game;
using AppForConcentration.Interfaces;

namespace AppForConcentration.GameForm
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            var gameObj = new GameClass();
            gameObj.Start();

            foreach (var figure in gameObj.startField)
            {
                var picture = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.AutoSize,
                        Image = figure.ImageFigure,
                        Location = new Point(figure.Position.X*64, figure.Position.Y*64)
                    };
                    this.Controls.Add(picture);
                
            }

            var selectingFigures = new List<IFigure> { new Circle(), new Square(), new Triangle() };

            for (var j = 0; j < 3; j++)
            {
                var figure = selectingFigures[j];
                var picture = new PictureBox
                {
                    Name = figure.Name,
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Image = figure.ImageFigure,
                    Location = new Point(j * 72 + 550,  64)
                };
                picture.Click += ClickSelectFigure ;
                this.Controls.Add(picture);
            }

            
        }

        private void ClickSelectFigure(object o, EventArgs args)
        {
            var pictureBox = (PictureBox) o;
            var namestr = pictureBox.Name;
        }
    }
}
