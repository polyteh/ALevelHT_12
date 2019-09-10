using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    public interface IShapes
    {
        // calculate square of the shape
        double Square { get; }
        // move shape left
        void MoveLeft();


       
    }
}
