using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Product
    {
        // Product binding class for AssocaitedParts.
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int productID;
        private string? name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        //Creating class parameters for Product.
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = "$" + price;
            InStock = inStock;
            Max = max;
            Min = min;

        }

        // Adding associated parts to the AssociatedParts Binding List.
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        // This will iterate through all of the associated parts in the binding list and remove it.
        public bool removeAssociatedPart(int partID)
        {
            bool removal = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return removal = true;
                }
                else
                {
                    removal = false;
                }

            }
            return removal;
        }

        // This will sort through all of the associated parts and if it returns no parts then it will create a random part that nobody will see.
        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            InHousePart emptyInHousePart = new InHousePart(0, "no part", 0, 0.00m, 0, 0, 000000);
            return emptyInHousePart;
        }



    }
}
