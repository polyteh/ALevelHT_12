using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    public abstract class Polygon
    {
        protected List<Point> topPoints= new List<Point>();
        protected List<double> sidesLenght = new List<double>();
        protected double shapeSquare;

        public double ScaleCoeff { get; set; }

        public virtual double GetDistanceBetweenPoints(Point _firstPoint, Point _secondPoint)
        {
            double sideLenght = Math.Pow(Math.Pow((_firstPoint.X - _secondPoint.X), 2) + Math.Pow((_firstPoint.Y - _secondPoint.Y), 2), 0.5);
            return sideLenght;
        }

        public List<Point> Resize(double scaleFactor)
        {
            List<Point> topPointsNew = new List<Point>();

            foreach (var topPoint in topPoints)
            {
                int newX = (int)scaleFactor * topPoint.X;
                int newY = (int)scaleFactor * topPoint.Y;
                topPointsNew.Add(new Point (newX, newY));
            }

            return topPointsNew;

        }

        protected void CalculateLenght()
        {
            for (int i = 0; i < topPoints.Count - 1; i++)
            {
                sidesLenght.Add(Math.Pow(Math.Pow((topPoints[i].X - topPoints[i + 1].X), 2) + Math.Pow((topPoints[i].Y - topPoints[i + 1].Y), 2), 0.5));
            }
            sidesLenght.Add( Math.Pow(Math.Pow((topPoints[topPoints.Count - 1].X - topPoints[0].X), 2) 
                + Math.Pow((topPoints[topPoints.Count - 1].Y - topPoints[0].Y), 2), 0.5));

        }
    }
}
