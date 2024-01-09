using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * An Abstract class for Part.
 * This will serve as a parent class for the Outsourced Class and the InHouseClass
 */
namespace App
{
    public abstract class Part
    {

        private int partID;
        private string? name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        

        public int PartID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        public Part(int partID, string name, int inStock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = "$" + price;
            Max = max;
            Min = min;

        }
    }
}
