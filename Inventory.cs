using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App
{
    public class Inventory
    {
        // Two binding lists for the products and all of the parts.
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        // Methods for Products
        public static void addProduct(Product product)
        {
            Products.Add(product); // Adds the newly created product to the products binding list.
        }

        public static bool removeProduct(int productID) 
        {
            // Returns a bool variable.
            bool didRemoveProduct = false;
            foreach (Product product in Products) // loops through all products until condition is met.
            {
                
                if (productID == product.ProductID)
                {
                    Products.Remove(product); // Found a product to remove using product ID
                    return didRemoveProduct = true;
                }
                else
                {
                    MessageBox.Show("REMOVAL FAILED"); // Failed to remove a product. 
                    return didRemoveProduct = false;
                }
            }
            return didRemoveProduct; // returns the remove product conclusion.
        }

        public static Product lookupProduct(int product_value) 
        {
            foreach (Product product in Products) // iterates through the products.
            {
                if (product.ProductID == product_value)
                {
                    return product;
                }
                
            }
            Product noProduct = new Product(0, "No Product Found", 00.0m, 0, 0, 0); // Creates a blank product that nobody will see if no product is returned.
            return noProduct;
        }

        public static void updateProduct(int productId, Product updatedProduct) 
        {
            removeProduct(productId); // Removes the product
            addProduct(updatedProduct); // Adds the updated version back.
        }

        // Methods for Parts
        public static void addPart(Part part) 
        {
            AllParts.Add(part); // Adds a new part object to the allParts binding list.
        }

        
        public static bool deletePart(int part) 
        {
            Part deletingPart = lookupPart(part); // creates a part and looks up the part.
            if (deletingPart == null) // If no part returned then returns false.
            {
                return false;
            }
            else
            {
                AllParts.Remove(deletingPart); // If part is returned then deletes part and returns true
                return true;
            }
        }

        public static Part lookupPart(int partID) 
        { 
            foreach(Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            InHousePart noPart = new InHousePart(0, "no part", 0, 0.00m, 0, 0, 000000); // Generates a blank part that nobody will see. 
            return noPart;
        }
        

        public static void updatePart(int partID, Part part) 
        {
            deletePart(partID); // deletes part
            addPart(part); // adds new updated part.
        }

        public static void generateInventory()
        {
            // This function is not neccessary. This is for testing purposes. This creates parts to display for the user to see and interact with.
            Product test = new Product(1, "Test Product", 10.0m, 2, 5, 1);
            Products.Add(test);

            InHousePart inhousetest = new InHousePart(1, "InHousePart Test", 10, 10.0m, 10, 1, 100250);
            OutsourcedPart outsourcedtest = new OutsourcedPart(2, "outsourced Test", 10, 10.0m, 10, 1, "Machine Parts Inc.");
            AllParts.Add(inhousetest);
            AllParts.Add(outsourcedtest);

        }
    }
}

