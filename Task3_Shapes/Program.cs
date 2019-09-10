using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle myTriangle = new Triangle(new Point(0, 0), new Point(0, 4), new Point(3, 0));
            Console.WriteLine($"Initial{myTriangle.ToString(),50}");
            double i = myTriangle.Square;
            Console.WriteLine($"Initial square {myTriangle.Square}");

            myTriangle++;
            Console.WriteLine($"Resized{myTriangle.ToString(),50}");
            Console.WriteLine($"Resized square {myTriangle.Square}");

            Console.ReadKey();
        }
    }
}
