using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppForConcentration.Interfaces;

namespace AppForConcentration.Game
{
    class Circle : IFigure
    {
        public DirectoryInfo Path { get; private set; }
        public string Name { get; set; }
        public Point Position { get; set; }
        public Bitmap ImageFigure { get; set; }

        public Circle()
        {
            Name = "Circle";
            Path = new DirectoryInfo("Figures");
            ImageFigure = (Bitmap) Image.FromFile(Path.FullName + @"\" + Name + ".bmp");
        }

        public object Clone()
        {
            return new Circle(){Path = this.Path, Name = this.Name,Position = this.Position,ImageFigure = this.ImageFigure};
        }
    }

    class Triangle : IFigure
    {
        public DirectoryInfo Path { get; private set; }
        public string Name { get; set; }
        public Point Position { get; set; }
        public Bitmap ImageFigure { get; set; }

        public Triangle()
        {
            Name = "Triangle";
            Path = new DirectoryInfo("Figures");
            ImageFigure = (Bitmap)Image.FromFile(Path.FullName + @"\" + Name + ".bmp");
        }

        public object Clone()
        {
            return new Triangle() { Path = this.Path, Name = this.Name, Position = this.Position, ImageFigure = this.ImageFigure };
        }
    }

    class Square : IFigure
    {
        public DirectoryInfo Path { get; private set; }
        public string Name { get; set; }
        public Point Position { get; set; }
        public Bitmap ImageFigure { get; set; }

        public Square()
        {
            Name = "Square";
            Path = new DirectoryInfo("Figures");
            ImageFigure = (Bitmap)Image.FromFile(Path.FullName + @"\" + Name + ".bmp");
        }

        public object Clone()
        {
            return new Square() { Path = this.Path, Name = this.Name, Position = this.Position, ImageFigure = this.ImageFigure };
        }
    }
}
