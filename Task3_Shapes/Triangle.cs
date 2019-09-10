using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    public class Triangle : Polygon, IShapes
    {

        public Triangle(Point _firstPoint, Point _secondPoint, Point _thirdPoint)
        {

            topPoints.Add(_firstPoint);
            topPoints.Add(_secondPoint);
            topPoints.Add(_thirdPoint);

            this.ScaleCoeff = 1;
            this.CalculateLenght();
        }


        public double Square
        {
            get
            {
                double polusumma = 0.5 * sidesLenght.Sum();
                double underSq = polusumma;
                foreach (var item in sidesLenght)
                {
                    underSq *= (polusumma - item);
                }
                this.shapeSquare = Math.Pow(underSq, 0.5);
                return this.shapeSquare;
            }
        }

        public double GetPerimeter()
        {
            Console.WriteLine("Rectangle perimeter");
            return 10;
        }
        public int GetNumberOfPoints()
        {
            Console.WriteLine("Rectangle number of points");
            return this.topPoints.Count;
        }

        public static Triangle operator ++(Triangle curTriangle)
        {
            curTriangle.ScaleCoeff *= 2;
            List<Point> newCoord = curTriangle.Resize(curTriangle.ScaleCoeff);

            return new Triangle(newCoord[0], newCoord[1], newCoord[2]);
        }

        public static Triangle operator --(Triangle curTriangle)
        {
            curTriangle.ScaleCoeff *= 0.5;
            List<Point> newCoord = curTriangle.Resize(curTriangle.ScaleCoeff);
            return new Triangle(newCoord[0], newCoord[1], newCoord[2]);
        }

        public override string ToString()
        {
            string defSitring = String.Format($"Triangle with coorditanes ({this.topPoints[0].X},{this.topPoints[0].Y}), ({this.topPoints[1].X},{this.topPoints[1].Y})," +
                $" ({this.topPoints[2].X},{this.topPoints[2].Y})");
            return defSitring;
        }

        public void MoveLeft()
        {

            for (int i = 0; i < topPoints.Count; i++)
            {
                topPoints[i] = new Point(topPoints[i].X - 1, topPoints[i].Y - 1);
            }
        }

    }
}
