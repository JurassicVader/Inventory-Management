using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * This page is nearly a copy and paste from the add Product page. 
 * Comments are on that page going over all the details
 */
namespace App
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> associatedParts = new BindingList<Part>();
        public ModifyProduct(Product product)
        {

            // populating the page with the data from the selected product.
            InitializeComponent();
            id_txtbox.Text = product.ProductID.ToString();
            name_txtbox.Text = product.Name.ToString();
            inventory_txtbox.Text = product.InStock.ToString();
            price_cost_txtbox.Text = product.Price.ToString().Remove(0, 1); // The .Remove(0, 1) is to remove the $ from the price textbox.
            max_txtbox.Text = product.Max.ToString();
            min_txtbox.Text = product.Min.ToString();

            // Populate all candidate Parts
            var partTable = new BindingSource();
            partTable.DataSource = Inventory.AllParts;
            candidate_parts_gridview.DataSource = partTable;

            // Populate all associated parts
            foreach (Part part in product.AssociatedParts)
            {
                associatedParts.Add(part);
            }
            var assocPartTable = new BindingSource();
            assocPartTable.DataSource = associatedParts;
            associated_parts_gridview.DataSource = assocPartTable;


        }

        private void products_search_btn_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(products_search_txtbox.Text);
            Part part = Inventory.lookupPart(partID);
            foreach (DataGridViewRow x in candidate_parts_gridview.Rows)
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

        private void add_parts_btn_Click(object sender, EventArgs e)
        {
            Part addPart = (Part)candidate_parts_gridview.CurrentRow.DataBoundItem;
            foreach (Part part in associatedParts)
            {
                if (addPart.PartID == part.PartID)
                {
                    MessageBox.Show("This part is already Associated");
                    return;
                }
            }
            associatedParts.Add(addPart);
        }

        private void delete_parts_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in associated_parts_gridview.SelectedRows)
            {
                associated_parts_gridview.Rows.RemoveAt(x.Index);
            }
            return;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // Using these variables to check the add Product screen.
            int productId = int.Parse(id_txtbox.Text);
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

            Product newProduct = new Product(productId, name, price, inventory, min, max);
            Inventory.updateProduct(productId, newProduct); // UpdateProduct instead of add product because this product is already created.

            foreach (Part part in associatedParts)
            {
                newProduct.addAssociatedPart(part);
            }


            Close();
        }
    }
}
