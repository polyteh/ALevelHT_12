using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Circles
{
    public class Circle
    {
        private Point circleCenter;
        private int circleRaius;
        private double circleSquare;
        private double circleLength;
        // I understand that coordinates is int only and it is garbage, but make new class..?
        private double tolerance = 0.05;

        public Circle(Point _center, int _radius)
        {
            this.circleCenter = _center;
            // if radius negative we throw exeption
            if (_radius > 0)
            {
                this.circleRaius = _radius;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Radius should be positive");
            }

        }

        public double Square()
        {
            circleSquare = Math.PI * Math.Pow(this.circleRaius, 2) * 0.5;
            return circleSquare;
        }

        public double Length()
        {
            circleLength = 2 * Math.PI * this.circleRaius;
            return circleSquare;
        }

        public bool isPointOnTheCircleLine(Point pointToCheck)
        {
            double distanceToPoint = Math.Pow((Math.Pow((this.circleCenter.X - pointToCheck.X), 2) + Math.Pow((this.circleCenter.Y - pointToCheck.Y), 2)), 0.5) - this.circleRaius;

            distanceToPoint = Math.Abs(distanceToPoint);
            if (distanceToPoint < tolerance)
            {
                return true;
            }
            return false;

        }


        public bool IsSquareEqual(Circle firstCircle, Circle secondCircle)
        {
            return firstCircle.circleRaius == secondCircle.circleRaius;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            Circle circleToCompare = obj as Circle;
            if (circleToCompare == null)
                return false;

            return this.circleRaius == circleToCompare.circleRaius;
        }

        public static bool operator ==(Circle circleFirst, Circle circleSecond)
        {
            return circleFirst.Equals(circleSecond);
        }
        public static bool operator !=(Circle circleFirst, Circle circleSecond)
        {
            return !circleFirst.Equals(circleSecond);
        }
        public override string ToString()
        {
            string defString = String.Format($"Circle this center ({this.circleCenter.X},{this.circleCenter.Y}) and radius {this.circleRaius}");
            return defString;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
