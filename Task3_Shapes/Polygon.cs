using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    // abstract class for triangle and rectangle
    public abstract class Polygon : IShapes
    {
        protected List<Point> topPoints = new List<Point>();
        protected List<double> sidesLenght = new List<double>();
        protected double polygonSquare, polygonPerimeter;
        bool updateLenght = false;

        public Polygon(List<Point> _listOfTops)
        {
            topPoints = _listOfTops;
            this.ScaleCoeff = 1;
            this.CalculateLenght();
        }

        public double ScaleCoeff { get; set; }

        public virtual double GetDistanceBetweenPoints(Point _firstPoint, Point _secondPoint)
        {
            double sideLenght = Math.Pow(Math.Pow((_firstPoint.X - _secondPoint.X), 2) + Math.Pow((_firstPoint.Y - _secondPoint.Y), 2), 0.5);
            return sideLenght;
        }

        protected void CalculateLenght()
        {
            // if  polygon was just created add new top points to the list
            if (!updateLenght)
            {
                for (int i = 0; i < topPoints.Count - 1; i++)
                {
                    sidesLenght.Add(Math.Pow(Math.Pow((topPoints[i].X - topPoints[i + 1].X), 2) + Math.Pow((topPoints[i].Y - topPoints[i + 1].Y), 2), 0.5));
                }
                sidesLenght.Add(Math.Pow(Math.Pow((topPoints[topPoints.Count - 1].X - topPoints[0].X), 2)
                    + Math.Pow((topPoints[topPoints.Count - 1].Y - topPoints[0].Y), 2), 0.5));
            }
            // overwise recalculate existing lenghts
            else
            {
                for (int i = 0; i < topPoints.Count - 1; i++)
                {
                    sidesLenght[i] = Math.Pow(Math.Pow((topPoints[i].X - topPoints[i + 1].X), 2) + Math.Pow((topPoints[i].Y - topPoints[i + 1].Y), 2), 0.5);
                }
                sidesLenght[topPoints.Count - 1] = Math.Pow(Math.Pow((topPoints[topPoints.Count - 1].X - topPoints[0].X), 2)
                    + Math.Pow((topPoints[topPoints.Count - 1].Y - topPoints[0].Y), 2), 0.5);
            }
        }

        protected List<Point> Resize(double scaleFactor)
        {
            List<Point> topPointsNew = new List<Point>();
            foreach (var topPoint in topPoints)
            {
                int newX = (int)(scaleFactor * topPoint.X);
                int newY = (int)(scaleFactor * topPoint.Y);
                topPointsNew.Add(new Point(newX, newY));
            }
            return topPointsNew;
        }

        // will be overloaded for each type of polygons
        public abstract double GetSquare();
        // calculate perimeter
        public double GetPerimeter()
        {
            foreach (var side in sidesLenght)
            {
                polygonPerimeter += side;
            };
            return polygonPerimeter;
        }
        // just move all point left
        public void MoveLeft()
        {
            for (int i = 0; i < topPoints.Count; i++)
            {
                topPoints[i] = new Point(topPoints[i].X - 1, topPoints[i].Y - 1);
            }
        }

        public void Rescale(double scale)
        {
            this.topPoints = Resize(scale);
            updateLenght = true;
            this.CalculateLenght();
        }
    }
}
