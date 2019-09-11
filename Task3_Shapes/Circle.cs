using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    public class Circle : IShapes
    {
        private Point centerCircle;
        int circleRadius;
        double circleSquare, sirclePerimetr;
        public Circle(Point _centerPoint, int _radius)
        {
            if (_radius > 0)
            {
                this.centerCircle = _centerPoint;
                this.circleRadius = _radius;
                this.ScaleCoeff = 1;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Radius should be positive");
            }
        }

        public double ScaleCoeff { get; set; }

        public double GetSquare()
        {
            circleSquare = Math.PI * Math.Pow(this.circleRadius, 2) * 0.5;
            return circleSquare;
        }
        public double GetPerimeter()
        {
            sirclePerimetr = 2 * Math.PI * this.circleRadius;
            return sirclePerimetr;
        }

        public void MoveLeft()
        {
            this.centerCircle = new Point(centerCircle.X - 1, centerCircle.Y - 1);
        }
        public void Rescale(double scale)
        {
            this.circleRadius = Resize(scale);
        }

        public override string ToString()
        {
            string defSitring = String.Format($"Circle with center coorditan({this.centerCircle.X},{this.centerCircle.Y}) and radius {this.circleRadius}");
            return defSitring;
        }

        private int Resize(double scaleFactor)
        {
            this.circleRadius = (int)(this.circleRadius * scaleFactor);
            return this.circleRadius;
        }
        public static Circle operator ++(Circle curCircle)
        {
            curCircle.ScaleCoeff *= 2;
            int newRadius = curCircle.Resize(curCircle.ScaleCoeff);

            return new Circle(curCircle.centerCircle, newRadius);
        }
        public static Circle operator --(Circle curCircle)
        {
            curCircle.ScaleCoeff *= 0.5;
            int newRadius = (int)(curCircle.Resize(curCircle.ScaleCoeff));

            return new Circle(curCircle.centerCircle, newRadius);
        }

    }
}

