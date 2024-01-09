using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class addProduct : Form
    {
        BindingList<Part> associatedParts = new BindingList<Part>(); // This is to store the associated parts for this page.
        public addProduct()
        {
            InitializeComponent();

            // Populate all candidate Parts
            var partTable = new BindingSource();
            partTable.DataSource = Inventory.AllParts;
            candidate_parts_gridview.DataSource = partTable;

            // This is generating the associated parts table contents. Should always be blank on this page.
            var assocPartTable = new BindingSource();
            assocPartTable.DataSource = associatedParts;
            associated_parts_gridview.DataSource = assocPartTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Ignore. Cannot locate label1_click as an action. 
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close(); // Closes the App.
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // Using these variables to check the add Product screen.
            string name;
            int inventory;
            decimal price;
            int max;
            int min;

            // Prevent the program from crashing due to inaccurate inputs
            try
            {
                // Collecting the data from the text boxes.
                name = name_txtbox.Text;
                inventory = int.Parse(inventory_txtbox.Text);
                price = decimal.Parse(price_cost_txtbox.Text);
                max = int.Parse(max_txtbox.Text);
                min = int.Parse(min_txtbox.Text);

                // Checking if Max is smaller than Min
                if (max < min)
                {
                    max_txtbox.BackColor = Color.Red;
                    min_txtbox.BackColor = Color.Red;
                    MessageBox.Show("The Max value cannot be smaller than Min");
                    return;
                }
                else
                {
                    max_txtbox.BackColor = Color.White;
                    min_txtbox.BackColor = Color.White;
                }
                // Checking if Inventory is greater than Max or smaller than Min.
                if (inventory > max || inventory < min)
                {
                    inventory_txtbox.BackColor = Color.Red;
                    MessageBox.Show("Inventory's value has to be between Max and Min's value");
                    return;
                }
                else { inventory_txtbox.BackColor = Color.White; }


            }
            catch
            {
                // Checking to see which fields have errors.
                // If any fields have any errors, the associated textbox(s) will turn red.


                int tryparse; // This is a variable to help check if the parses work in the textboxes.
                decimal mtryparse; // m - tryparse for decimal.

                if (name_txtbox.Text is not String || name_txtbox.Text == "")
                {
                    name_txtbox.BackColor = Color.Red;
                }
                else { name_txtbox.BackColor = Color.White; }

                if (inventory_txtbox.Text == "" || !int.TryParse(inventory_txtbox.Text, out tryparse))
                {
                    inventory_txtbox.BackColor = Color.Red;

                }
                else { inventory_txtbox.BackColor = Color.White; }

                if (price_cost_txtbox.Text == "" || !decimal.TryParse(price_cost_txtbox.Text, out mtryparse))
                {
                    price_cost_txtbox.BackColor = Color.Red;
                }
                else { price_cost_txtbox.BackColor = Color.White; }

                if (max_txtbox.Text == "" || !int.TryParse(max_txtbox.Text, out tryparse))
                {
                    max_txtbox.BackColor = Color.Red;
                }
                else { max_txtbox.BackColor = Color.White; }

                if (min_txtbox.Text == "" || !int.TryParse(min_txtbox.Text, out tryparse))
                {
                    min_txtbox.BackColor = Color.Red;
                }
                else { min_txtbox.BackColor = Color.White; }

                MessageBox.Show("ERROR: Please fill out or fix the highlighted fields.");
                return; // Stop from closing the screen. Makes the user change the values.

            }

            // Generating a new product.
            Product newProduct = new Product(Inventory.Products.Count + 1, name, price, inventory, min, max);
            Inventory.addProduct(newProduct);

            foreach (Part part in associatedParts) // Adding the associated parts to the newly created product.
            {
                newProduct.addAssociatedPart(part);
            }


            Close();
        }

        private void add_parts_btn_Click(object sender, EventArgs e)
        {
            // This will add any associated parts.
            Part addPart = (Part)candidate_parts_gridview.CurrentRow.DataBoundItem;
            foreach(Part part in associatedParts) // If the part is already selected then this will prevent the user from adding the same part twice.
            {
                if (addPart.PartID == part.PartID)
                {
                    MessageBox.Show("This part is already Associated"); // If the user attempts to add the same part twice, it will pop up this error message.
                    return; // Break out of the function before it reaches, the add function.
                }
            }
            associatedParts.Add(addPart); // This adds the part.


        }

        private void delete_parts_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in associated_parts_gridview.SelectedRows) // Loops through all of the deleted parts.
            {
                associated_parts_gridview.Rows.RemoveAt(x.Index); // removes the row.
            }
            return;
            
        }

        private void products_search_btn_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(products_search_txtbox.Text); // Takes the number from the search bar.
            Part part = Inventory.lookupPart(partID); // Runs the Inventory LookupPart function and assigns the partID to a new part object.
            foreach (DataGridViewRow x in candidate_parts_gridview.Rows) // iterates through the rows. 
            {
                Part lookpart = (Part)x.DataBoundItem;
                if (lookpart.PartID == part.PartID)
                {
                    x.Selected = true;
                    break;
                }
                else { x.Selected = false; }
            }
        }
    }
}
