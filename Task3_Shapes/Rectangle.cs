using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    public class Rectangle:Polygon, IShapes
    {
        public Rectangle(Point _leftToptPoint, int lenght, int height)
        {
            if (lenght<=0||height<=0)
            {
                throw new IndexOutOfRangeException("dimension should be positive");
            }
            topPoints.Add(_leftToptPoint);
            topPoints.Add(new Point(_leftToptPoint.X-lenght, _leftToptPoint.Y));
            topPoints.Add(new Point(_leftToptPoint.X - lenght, _leftToptPoint.Y-height));
            topPoints.Add(new Point(_leftToptPoint.X, _leftToptPoint.Y - height));
        }

        public double Square
        {
            get { return 1; }
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
        public void MoveLeft()
        {

            for (int i = 0; i < topPoints.Count; i++)
            {
                topPoints[i] = new Point(topPoints[i].X - 1, topPoints[i].Y - 1);
            }
        }

    }
}
