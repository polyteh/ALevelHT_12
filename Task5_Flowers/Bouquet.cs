using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Flowers
{
    public class Bouquet
    {
        // dictionary to save data
        private Dictionary<Flower, int> curBouquet = new Dictionary<Flower, int>();

        // make price
        public int Price
        {
            get
            {
                int bouquetPrice = 0;
                foreach (var flower in curBouquet)
                {
                    bouquetPrice += flower.Key.Price * flower.Value;
                }
                return bouquetPrice;
            }
        }

        /// <summary>
        /// add new flower to bouquet or update if exists
        /// </summary>
        /// <param name="key">flower object</param>
        /// <param name="quantity">quantity</param>
        public void AddOrUpdateFlower(Flower key, int quantity)
        {
            int val;
            if (curBouquet.TryGetValue(key, out val))
            {
                curBouquet[key] = val + quantity;
            }
            else
            {
                curBouquet.Add(key, quantity);
            }
        }
        /// <summary>
        /// remove flower from the bouquet
        /// </summary>
        /// <param name="key">flower object</param>
        /// <param name="quantity">quantity</param>
        public void RemoveFlower(Flower key, int quantity)
        {
            int val;
            if (curBouquet.TryGetValue(key, out val))
            {
                if (val > quantity)
                {
                    curBouquet[key] = val - quantity;
                }
                else if (val == quantity)
                {
                    curBouquet.Remove(key);
                }
                else
                {
                    Console.WriteLine("Too few flowers of this type");
                }
            }
            else
            {
                throw new ArgumentException("No such flower in the current bouqet");
            }
        }

        /// <summary>
        /// just display method
        /// </summary>
        public void DisplayBouquet()
        {
            Console.WriteLine("Current bouguet");
            Console.WriteLine($"Flower name\t Flower colour\t Flower price\t Quantity");
            foreach (var flower in curBouquet)
            {
                Console.WriteLine($"{flower.Key.Name,15}{flower.Key.Colour,10}{flower.Key.Price,15}{flower.Value,10}");

            }
        }

    }
}
