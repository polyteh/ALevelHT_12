using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Warehouse
{
    public class Furniture : Product, IProductAction
    {
        private enum QualityRate { Normal = 1, Premium }
        QualityRate qRate;
        public Furniture(string _name, string _manufacturer, int _price) : base(_name, _manufacturer, _price)
        {
            qRate = QualityRate.Normal;
        }

        public void UpdateQuality()
        {
            qRate = QualityRate.Premium;
            this.Price= (int)(this.Price * 1.20);
            this.PetName += "_premium";
        }

        public void MakeDiscount()
        {

            switch (qRate)
            {
                case QualityRate.Normal:
                    {
                        this.Price = (int)(this.Price * 0.90);
                        break;
                    }
                case QualityRate.Premium:

                    {
                        this.Price = (int)(this.Price*0.95);
                        break;
                    }

                default:
                    break;
            }
        }

    }

}
