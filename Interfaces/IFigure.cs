using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppForConcentration.Interfaces
{
    public interface IFigure : ICloneable
    {
        DirectoryInfo Path { get; }
        string Name { get; set; }
        Point Position { get; set; }
        Bitmap ImageFigure { get; set; }
    }
}