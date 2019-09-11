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
            try
            {
                // create new traingle (right triangle), calculate the square
                List<Point> triangleTops = new List<Point>() { new Point(0, 0), new Point(0, 4), new Point(3, 0) };
                Triangle myTriangle = new Triangle(triangleTops);
                Console.WriteLine($"Initial {myTriangle.ToString(),50}");
                Console.WriteLine($"Initial triangle square {myTriangle.GetSquare()}");
                // scale all dimensions of triangle (coefficient of scale =2) and recalculate the square
                myTriangle++;
                Console.WriteLine($"Resized {myTriangle.ToString(),50}");
                Console.WriteLine($"Resized triangle square {myTriangle.GetSquare()}");
                Console.WriteLine(new string('=', 50));

                // create new rectangle, calculate the square
                List<Point> rectTops = new List<Point>() { new Point(0, 4), new Point(3, 4), new Point(3, 0), new Point(0, 0) };
                Rectangle myRectangle = new Rectangle(rectTops);
                Console.WriteLine($"Initial rectangle {myRectangle.ToString()}");
                Console.WriteLine($"Initial rectangle square {myRectangle.GetSquare()}");
                // move rectangle left
                myRectangle.MoveLeft();
                Console.WriteLine($"Moved  rectangle {myRectangle.ToString()}");
                Console.WriteLine($"Moved rectangle square {myRectangle.GetSquare()}");
                // scale rectangle with ++ (coefficient of scale =2) and recalculate the square
                myRectangle++;
                Console.WriteLine($"Scaled (with++) and moved  rectangle {myRectangle.ToString()}");
                Console.WriteLine($"Scaled (with++) and moved rectangle square {myRectangle.GetSquare()}");
                //  back scale with IShape method
                myRectangle.Rescale(0.5);
                Console.WriteLine($"Scaled back rectangle {myRectangle.ToString()}");
                Console.WriteLine($"Scaled back rectangle square {myRectangle.GetSquare()}");
                Console.WriteLine(new string('=', 50));

                // create new square
                List<Point> sqTops = new List<Point>() { new Point(0, 4), new Point(4, 4), new Point(4, 0), new Point(0, 0) };
                Square mySquare = new Square(sqTops);
                Console.WriteLine($"Initial square {mySquare.ToString()}");
                Console.WriteLine($"Initial square of square {mySquare.GetSquare()}");
                // scale with Rescale
                mySquare.Rescale(2);
                Console.WriteLine($"Scaled square {mySquare.ToString()}");
                Console.WriteLine($"Scaled square of square {mySquare.GetSquare()}");
                Console.WriteLine(new string('=', 50));

                // create new circle
                Circle myCircle = new Circle(new Point(5, 5), 10);
                Console.WriteLine($"{myCircle.ToString(),50}");
                Console.WriteLine($"Initial square of circle {myCircle.GetSquare():.##}");
                // rescale with ++
                myCircle++;
                Console.WriteLine($"Rescaled  {myCircle.ToString(),50}");
                Console.WriteLine($"Square of rescaled circle {myCircle.GetSquare():.##}");
                // move circle left
                myCircle.MoveLeft();
                Console.WriteLine($"Rescaled and moved {myCircle.ToString(),50}");
                Console.WriteLine($"Square of rescaled and moved circle {myCircle.GetSquare():.##}");

                Console.WriteLine("I HATE GEOMETRY SINCE NOW");

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {


            }

            Console.ReadKey();
        }
    }
}
