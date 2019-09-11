using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Warehouse
{
    public class Warehouse
    {
        private Dictionary<Product, int> curWarehouse = new Dictionary<Product, int>();

        public void AddOrUpdateProduct(Product key, int quantity)
        {
            int val;
            if (curWarehouse.TryGetValue(key, out val))
            {
                curWarehouse[key] = val + quantity;
            }
            else
            {
                curWarehouse.Add(key, quantity);
            }
        }
        public void RemoveProduct(Product key, int quantity)
        {
            int val;
            if (curWarehouse.TryGetValue(key, out val))
            {
                if (val > quantity)
                {
                    curWarehouse[key] = val - quantity;
                }
                else if (val == quantity)
                {
                    curWarehouse.Remove(key);
                }
                else
                {
                    Console.WriteLine("Too few product of this type");
                }
            }
            else
            {
                throw new ArgumentException("No such product in the warehouse");
            }
        }
        public void RemoveProduct(Product key)
        {
            int val;
            if (curWarehouse.TryGetValue(key, out val))
            {

                curWarehouse.Remove(key);
            }
            else
            {
                throw new ArgumentException("No such product in the warehouse");
            }
        }

        public void DisplayWarehouse()
        {

            Console.WriteLine($"Product name\tProduct manufacturer\tProduct price\tQuantity");
            foreach (var product in curWarehouse)
            {
                Console.WriteLine($"{product.Key.PetName,15}{product.Key.Manufacturer,25}{product.Key.Price,15}{product.Value,10}");

            }
        }

        public void ChangeManufacturer(Product key, string _newManufacturer)
        {
            int val;
            if (curWarehouse.TryGetValue(key, out val))
            {

                key.Manufacturer = _newManufacturer;
            }
            else
            {
                throw new ArgumentException("No such product in the warehouse");
            }

        }



    }
}
