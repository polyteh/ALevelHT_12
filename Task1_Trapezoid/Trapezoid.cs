using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1_Trapezoid
{
    public class Trapezoid
    {
        //private Point point1, point2, point3, point4;
        private Point[] trapezTops;
        private double[] sideLenght;
        private double trapezSquare, trapezPerimeter;
        //private double sideLenght12, sideLenght23, sideLenght34, sideLenght41;
        public Trapezoid(string _name, Point _point1, Point _point2, Point _point3, Point _point4)
        {
            trapezTops = new Point[4];
            sideLenght = new double[4];

            this.trapezTops[0] = _point1;
            this.trapezTops[1] = _point2;
            this.trapezTops[2] = _point3;
            this.trapezTops[3] = _point4;

            this.Name = _name;

            this.sideLenght = new double[4];
            this.CalculateSides();
            this.CalculateIntegralParameters();
        }

        public string Name { get; set; }
        public double Square
        {
            get
            {
                return this.trapezSquare;
            }
        }
        public double Perimeter
        {
            get
            {
                return this.trapezPerimeter;
            }
        }


        /// <summary>
        /// check if trapezoid is isosceles
        /// </summary>
        /// <returns>reurn tue if isosceles, owerwisr return false</returns>
        public bool IsIsosceles()
        {
            /*
            double diag1 = Math.Pow(Math.Pow((trapezTops[0].X - trapezTops[2].X), 2) + Math.Pow((trapezTops[0].Y - trapezTops[2].Y), 2), 0.5);
            double diag2 = Math.Pow(Math.Pow((trapezTops[1].X - trapezTops[3].X), 2) + Math.Pow((trapezTops[1].Y - trapezTops[3].Y), 2), 0.5);
            return diag1 == diag2 ? true : false;
            */
            return this.sideLenght[1] == this.sideLenght[3] ? true : false;

        }

        private void CalculateSides()
        {
            // i dont know how: is current realization good? or it is better to check index for the limit on the each step  with if and make
            // all calculation inside for statement?
            for (int i = 0; i < sideLenght.Length - 1; i++)
            {
                sideLenght[i] = Math.Pow(Math.Pow((trapezTops[i].X - trapezTops[i + 1].X), 2) + Math.Pow((trapezTops[i].Y - trapezTops[i + 1].Y), 2), 0.5);
            }
            sideLenght[sideLenght.Length - 1] = Math.Pow(Math.Pow((trapezTops[3].X - trapezTops[0].X), 2) + Math.Pow((trapezTops[3].Y - trapezTops[0].Y), 2), 0.5);
        }


        // calculate perimeter and square
        private void CalculateIntegralParameters()
        {
            // calculate perimeter
            foreach (var side in this.sideLenght)
            {
                this.trapezPerimeter += side;
            }

            // calculate square
            this.trapezSquare = ((this.sideLenght[0] + this.sideLenght[2]) / 2) * (this.trapezTops[0].Y - this.trapezTops[3].Y);

        }


    }
}
