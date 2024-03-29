﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // С использованием построенного класса создайте две окружности: одну с центром в (0;0) и радиусом 12, а вторую с центром в (3;5) и радиусом 11.
                // Проверьте с помощью созданного метода равна ли их площадь и если равна, то выведите соответсвующее сообщение на экран.
                Circle myCircle1 = new Circle(new Point(0, 0), 12);
                Circle myCircle2 = new Circle(new Point(3, 5), 11);

                // check for square
                Console.WriteLine($"We compare circles\n{myCircle1.ToString()}\nand\n{myCircle2.ToString()}");
                Console.WriteLine(myCircle1 == myCircle2 ? $"Equal" : $"Not equal");

                // check if point is on the circle line
                Point firstPoint = new Point(0, 12);
                Point secondPoint = new Point(0, 1);
                Console.WriteLine(myCircle1.isPointOnTheCircleLine(firstPoint) ? $"Point on the line" : $"Point is far");
                Console.WriteLine(myCircle1.isPointOnTheCircleLine(secondPoint) ? $"Point on the line" : $"Point is far");

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (Exception)
            {


            }

            Console.ReadKey();
        }
    }
}
