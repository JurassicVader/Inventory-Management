/* Application was created by Spencer Burchfield
 * Project was completed on 12/6/23
 * Edited on 12/9/23 - Fixed Exception handing in Machine ID field on Add Part and Modify Part.
 *      Cannot delete products with associated parts.
 */
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Initializing the page and populating the tables
            InitializeComponent();
            Inventory.generateInventory(); // Generating the table data.

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.AllParts;
            parts_grid_view.DataSource = partTable; // Populating the parts grid rows

            var productTable = new BindingSource();
            productTable.DataSource = Inventory.Products;
            products_grid_view.DataSource = productTable; // Populating the products grid rows
        }


        private void EXIT_btn_Click(object sender, EventArgs e) // Exit button to close the application.
        {
            //Application.Exit(); // Does this work better? Is it more safe?
            Close();
        }

        private void parts_add_btn_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog(); // opening a new blank, add Parts page
        }

        private void products_add_btn_Click(object sender, EventArgs e)
        {
            new addProduct().ShowDialog(); // Opening a new blank, add Products page
        }

        private void parts_search_btn_Click(object sender, EventArgs e)
        {
            // Using try to not crash the program.
            try
            {
                
                int search_input = int.Parse(parts_search_txtbox.Text); // Whats in the searchbox.

                if (search_input < 1) return; // Verifying that there is real input.

                Part match = Inventory.lookupPart(search_input); // Making a fake Part object to compare Part IDs with

                foreach (DataGridViewRow row in parts_grid_view.Rows) // Looping through all rows until it makes a match with a real Part ID
                {
                    Part part = (Part)row.DataBoundItem;
                    if (part.PartID == match.PartID)
                    {
                        row.Selected = true;
                        break;

                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
            catch (Exception E) // If the Value is not an integer it will send a message box.
            {
                MessageBox.Show("Value needs to be an integer value", E.Message);
            }


        }

        private void products_search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int searchValue = int.Parse(products_search_txtbox.Text); // This is what is in the searchbox.

                if (searchValue < 1) return; // Verifying that there is a real input. 

                Product match = Inventory.lookupProduct(searchValue); // Creating a fake product object to compare Part IDs with.


                foreach (DataGridViewRow rows in products_grid_view.Rows) // Looping through all rows until it makes a match with a real product.
                {
                    Product product = (Product)rows.DataBoundItem;
                    if (product.ProductID == match.ProductID)
                    {
                        rows.Selected = true;
                        break;
                    }
                    else
                    {
                        rows.Selected = false;
                    }
                }
            }
            catch (Exception E) // If the value is not an integer, it will send a message box.
            {
                MessageBox.Show("Value needs to be an integer value", E.Message);
            }

        }

        private void parts_delete_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in parts_grid_view.SelectedRows) // Loops through each selected row and removes the selected rows. 
            {
                parts_grid_view.Rows.RemoveAt(rows.Index);
            }
        }

        private void products_delete_btn_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow rows in products_grid_view.SelectedRows)  // Loops through each selected row and removes the selected rows. 
            {
                Product product = (Product)rows.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete products with Associated Parts.");
                    return;
                }
                products_grid_view.Rows.RemoveAt(rows.Index);
            }
        }

        private void parts_modify_btn_Click(object sender, EventArgs e)
        {
            if(parts_grid_view.CurrentRow.DataBoundItem.GetType() == typeof(App.InHousePart)) // This checks if the part is an InHouse Part. 
            {
                InHousePart selected_inHousePart = (InHousePart)parts_grid_view.CurrentRow.DataBoundItem; // setting this new part to what is selected.
                new Modify(selected_inHousePart).ShowDialog(); // Creating the new Modify Part window with the part above.
            }
            else if (parts_grid_view.CurrentRow.DataBoundItem.GetType() == typeof(App.OutsourcedPart)) // This check if the part is an Outsourced Part. This used to be an else statement but it caused errors. 
            {
                OutsourcedPart selected_outsourcedPart = (OutsourcedPart)parts_grid_view.CurrentRow.DataBoundItem; // setting this new part to what is selected.
                new Modify(selected_outsourcedPart).ShowDialog(); // Creating the new Modify Part window with the part above.
            }


        }

        private void products_modify_btn_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)products_grid_view.CurrentRow.DataBoundItem; // Setting this new product to what is selected in the products grid.
            new ModifyProduct(selectedProduct).ShowDialog(); // Creating a new Modify products window with the object above.
        }
    }
}