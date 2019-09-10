using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        { 
            // make trapezoid list
            List<Trapezoid> myTestTrapez = new List<Trapezoid>()
            {
                new Trapezoid ("first", new Point(5,5), new Point (10,5), new Point (15,0), new Point(0,0)),
                new Trapezoid ("second",new Point(1,10), new Point (2,10), new Point (3,0), new Point(0,0)),
                new Trapezoid ("third",new Point(1,20), new Point (2,20), new Point (3,0), new Point(0,0)),
                new Trapezoid ("fourth", new Point(2,2), new Point (4,2), new Point (4,0), new Point(0,0))
            };

            foreach (var trapez in myTestTrapez)
            {
                Console.WriteLine($"Trapez {trapez.Name} squzre is {trapez.Square:0.##}, perimeter is {trapez.Perimeter:0.##}");
            };
            Console.WriteLine(new string('=', 50));

            // calculate average square
            double averageSquare = myTestTrapez.Average(trapez=>trapez.Square);

            // make list of trapezoid with square greater than average
            IEnumerable<Trapezoid> squareAboveAverage = myTestTrapez.Where(trapez=> trapez.Square>averageSquare);
            Console.WriteLine($"Only {squareAboveAverage.Count()} have square greater than average (average square is {averageSquare:0.##}). They names are");

            foreach (var trapez in squareAboveAverage)
            {
                Console.WriteLine($"Trapez {trapez.Name}");
            }
            Console.WriteLine(new string('=',50));

            // check two trapezoid for if is isosceles
            Console.WriteLine(myTestTrapez[0].IsIsosceles()?$"Trapez {myTestTrapez[0].Name} is isosceles": $"Trapez {myTestTrapez[0].Name} is not isosceles");
            Console.WriteLine(myTestTrapez[3].IsIsosceles()?$"Trapez {myTestTrapez[3].Name} is isosceles" :$"Trapez {myTestTrapez[3].Name} is not isosceles");

            Console.ReadKey();

        }
    }
}
