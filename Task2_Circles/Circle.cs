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
        private double circleRaius;
        private double circleSquare;

        public Circle(Point _center, double _radius)
        {
            this.circleCenter = _center;
            // if radius negative we throw exeption
            if (_radius>0)
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
            circleSquare = Math.PI * Math.Pow(this.circleRaius,2) * 0.5;
            return circleSquare;
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

        public static bool operator == (Circle circleFirst, Circle circleSecond)
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
