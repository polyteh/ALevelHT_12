using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shapes
{
    public class Square : Rectangle
    {
        public Square(List<Point> _listOfTops) : base(_listOfTops)
        {

            if (sidesLenght.Distinct().Count() > 1)
            {
                throw new IndexOutOfRangeException("it is not a square");
            }
        }

    }
}
