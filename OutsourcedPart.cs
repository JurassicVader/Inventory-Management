using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
 * Creates a child class named OutsourcedPart to the Parent class Part
 * It calls all of parents variables but saves space and time.
 */
namespace App
{
    public class OutsourcedPart : Part
    {
        private string companyName;

        public string CompanyName { get; set; }
        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min, string companyName)
            : base(partID, name, inStock, price, max, min)
        {

            CompanyName = companyName;

        }
    }
}
