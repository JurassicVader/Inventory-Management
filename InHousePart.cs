using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * Creates a child class named InHousePart to the Parent class Part
 * It calls all of parents variables but saves space and time.
 */
namespace App
{
    public class InHousePart : Part
    {
        private int machineID;
        private static int partID;
        private static string name;
        private static int inStock;
        private static decimal price;
        private static int max;
        private static int min;

        public int MachineID { get; set; }


        public InHousePart (int partID, string name, int inStock, decimal price, int max, int min, int machineID) 
            : base(partID, name, inStock, price, max, min)
        {
            MachineID = machineID;
        }
    }
}
