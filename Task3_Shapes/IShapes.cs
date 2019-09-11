using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    public interface IShapes
    {
        // calculate square of the shape
        double GetSquare();
        // calculate perimeter of the shape
        double GetPerimeter();
        // move shape left
        void MoveLeft();

        // rescale with scale factor
        double ScaleCoeff { get; set; }
        void Rescale(double scale);


    }
}
