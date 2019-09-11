using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse myWarehouse = new Warehouse();

            try
            {
                Furniture myTable = new Furniture("Table", "Apple", 500);
                Furniture myChair = new Furniture("Chair", "Diadora", 100);
                WoodPanels myDSP = new WoodPanels("DSP", "FP Buratino",10,20,20);
                WoodPanels myMDF = new WoodPanels("MDF", "FP Buratino", 15, 30, 30);

                myWarehouse.AddOrUpdateProduct(myTable, 1);
                myWarehouse.AddOrUpdateProduct(myChair, 4);
                myWarehouse.AddOrUpdateProduct(myDSP, 10);
                myWarehouse.AddOrUpdateProduct(myMDF, 5);
                Console.WriteLine("Initial warehouse");
                myWarehouse.DisplayWarehouse();
                Console.WriteLine(new string ('=',50));

                // make discount for Chair
                Console.WriteLine("Make discount for chair");
                myChair.MakeDiscount();
                myWarehouse.DisplayWarehouse();
                Console.WriteLine(new string('=', 50));

                // remove 1 chair and 1 table
                Console.WriteLine("Remove 1 chair and 1 table");
                myWarehouse.RemoveProduct(myChair,1);
                myWarehouse.RemoveProduct(myTable);
                myWarehouse.DisplayWarehouse();
                Console.WriteLine(new string('=', 50));

                // update MDF quality
                Console.WriteLine("Update MDF quality");
                myMDF.UpdateQuality();
                myWarehouse.DisplayWarehouse();
                Console.WriteLine(new string('=', 50));

                // change DSP manufacturer
                Console.WriteLine("Change DSP manufacturer");
                myWarehouse.ChangeManufacturer(myDSP, "Roga i kopyta");
                myWarehouse.DisplayWarehouse();

            }
            catch (Exception)
            {

                throw;
            }


            Console.ReadKey();

        }
    }
}
