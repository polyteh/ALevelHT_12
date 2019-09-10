using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {


            // define several flowers
            Flower tulipYellow = new Flower("tulip","yellow",15);
            Flower tulipRed = new Flower("tulip", "red", 10);
            Flower roseYellow = new Flower("rose", "yellow", 60);
            Flower roseRed = new Flower("rose", "red", 50);

            // create new bouquet
            Bouquet myBouquet = new Bouquet();

            try
            {
                // add 1 yellow and 2 red tulip to the myBouquet, print bouquet and price
                Console.WriteLine("Add 1 yellow and 2 red tulip to the myBouquet, print bouquet and price");
                myBouquet.AddOrUpdateFlower(tulipYellow, 1);
                myBouquet.AddOrUpdateFlower(tulipRed, 2);
                myBouquet.DisplayBouquet();
                Console.WriteLine($"Current bouquet price is {myBouquet.Price}");
                Console.WriteLine(new string('=', 50));

                // add 2 yellow tulip, to yellow roses and one red rose to the myBouquet, print bouquet and price
                Console.WriteLine("Add 2 yellow tulip, to yellow roses and one red rose to the myBouquet, print bouquet and price");
                myBouquet.AddOrUpdateFlower(tulipYellow, 1);
                myBouquet.AddOrUpdateFlower(roseYellow, 2);
                myBouquet.AddOrUpdateFlower(roseRed, 1);
                myBouquet.DisplayBouquet();
                Console.WriteLine($"Current bouquet price is {myBouquet.Price}");
                Console.WriteLine(new string('=', 50));

                // remove 1 yellow rose
                Console.WriteLine("Remove 1 yellow rose");
                myBouquet.RemoveFlower(roseYellow, 1);
                myBouquet.DisplayBouquet();
                Console.WriteLine($"Current bouquet price is {myBouquet.Price}");
                Console.WriteLine(new string('=', 50));

                // remove last yellow rose
                Console.WriteLine("Remove last yellow rose");
                myBouquet.RemoveFlower(roseYellow, 1);
                myBouquet.DisplayBouquet();
                Console.WriteLine($"Current bouquet price is {myBouquet.Price}");
                Console.WriteLine(new string('=', 50));

                // and try once again remove yellow rose, exception
                Console.WriteLine("Remove yellow rose. But we havent!");
                myBouquet.RemoveFlower(roseYellow, 1);
                myBouquet.DisplayBouquet();
                Console.WriteLine($"Current bouquet price is {myBouquet.Price}");
                Console.WriteLine(new string('=', 50));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception)
            {

            }
            Console.ReadKey();
        }

       


    }
}
