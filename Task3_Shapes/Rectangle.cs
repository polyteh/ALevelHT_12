using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    public class Rectangle : Polygon
    {
        public Rectangle(List<Point> _listOfTops) : base(_listOfTops)
        {

            if (sidesLenght[0] != sidesLenght[2] || sidesLenght[1] != sidesLenght[3])
            {
                throw new IndexOutOfRangeException("it is not a rectangle");
            }
        }
        /*
        public Rectangle(Point _leftToptPoint, Point _rightTopPoint, Point _rightBottomPoint, Point _leftBottomPoint)
        {
            topPoints.Add(_leftToptPoint);
            topPoints.Add(_rightTopPoint);
            topPoints.Add(_rightBottomPoint);
            topPoints.Add(_leftBottomPoint);
            this.ScaleCoeff = 1;
            this.CalculateLenght();

            if (sidesLenght[0] !=sidesLenght[2] || sidesLenght[1] != sidesLenght[3])
            {
                throw new IndexOutOfRangeException("it is not a rectangle");
            }
        }
        */
        public override double GetSquare()
        {
            this.polygonSquare = sidesLenght[0] * sidesLenght[1];
            return this.polygonSquare;
        }

        public int GetNumberOfPoints()
        {
            Console.WriteLine("Rectangle number of points");
            return this.topPoints.Count;
        }

        public override string ToString()
        {
            string defSitring = String.Format($"Coorditanes\n({this.topPoints[0].X},{this.topPoints[0].Y})\t({this.topPoints[1].X},{this.topPoints[1].Y})\n" +
                $"({this.topPoints[3].X},{this.topPoints[3].Y})\t({this.topPoints[2].X},{this.topPoints[2].Y})");
            return defSitring;
        }
        public static Rectangle operator ++(Rectangle curTriangle)
        {
            curTriangle.ScaleCoeff *= 2;
            List<Point> newCoord = curTriangle.Resize(curTriangle.ScaleCoeff);

            return new Rectangle(newCoord);
        }
        public static Rectangle operator --(Rectangle curTriangle)
        {
            curTriangle.ScaleCoeff *= 0.5;
            List<Point> newCoord = curTriangle.Resize(curTriangle.ScaleCoeff);

            return new Rectangle(newCoord);
        }




    }
}
