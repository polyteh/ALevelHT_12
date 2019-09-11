using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Warehouse
{
    
    public class WoodPanels: Product, IProductAction
    {
        private bool trimming = false;
        private double trimingPrice = 0.025;

        public WoodPanels(string _name, string _manufacturer, int _price, int _height, int _width) : base(_name, _manufacturer, _price)
        {
            this.Height = _height;
            this.Widht = _width;

        }

        public int Height { get; set; }
        public int Widht { get; set; }


        public void UpdateQuality()
        {
            this.trimming = true;
            this.Price = (int)(trimingPrice * this.Height * this.Widht);
            this.PetName += "_trimmed";

        }

        public void MakeDiscount()
        {

            switch (trimming)
            {
                case true:
                    {
                        this.Price = (int)(this.Price * 0.95);
                        break;
                    }
                case false:

                    {

                        this.Price = (int)(this.Price * 0.90);
                        break;
                    }


            }
        }

    }
}
