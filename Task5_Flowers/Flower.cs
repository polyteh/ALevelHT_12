using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Flowers
{
    public class Flower
    {
        // for hash code
        private static int flowerID=0;

        public Flower(string _name, string _colour, int _price)
        {
            this.Name = _name;
            this.Colour = _colour;
            this.Price = _price;
            flowerID++;
        }

        public string Name { get; set; }
        public string Colour { get; set; }
        public int Price { get; set; }

        // override methods to work with Flower like key in dictionary
        public override int GetHashCode()
        {
            return flowerID;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Flower flowerToCompare = obj as Flower;
            if (flowerToCompare == null)
                return false;
            return (this.Name == flowerToCompare.Name)&&(this.Colour == flowerToCompare.Colour);
        }

    }
}
