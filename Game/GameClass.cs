using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using AppForConcentration.Game;
using AppForConcentration.Interfaces;

namespace AppForConcentration.Game
{
    class GameClass
    {
        public Player Player;
        public List<IFigure> Figures;
        public IFigure[,] startField;
        public IFigure[,] playerField;

        public GameClass()
        {
            this.startField = new IFigure[3,3];
            this.playerField = new IFigure[3, 3];
            Figures = new List<IFigure> {new Circle(), new Square(), new Triangle()};
        }

        public void Start()
        {
            var random = new Random();
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var figure = (IFigure)Figures[random.Next(0, 3)].Clone();
                    figure.Position = new Point(j, i);
                    startField[i, j] = figure;
                }
            }
        }
    }


}
