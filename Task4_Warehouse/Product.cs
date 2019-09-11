using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Warehouse
{
    public class Product
    {
        // for hash code
        private static int productID = 0;
        public Product(string _name,  string _manufacturer, int _price)
        {
            PetName = _name;
            Price = _price;
            Manufacturer = _manufacturer;
            productID++;
        }
        public string PetName { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }

        public override int GetHashCode()
        {
            return productID;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Product productToCompare = obj as Product;
            if (productToCompare == null)
                return false;
            return (this.PetName == productToCompare.PetName)&&(this.Manufacturer==productToCompare.Manufacturer);
        }
    }
}
