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
 * This page is nearly a copy and paste from the add parts page. 
 * Refer to what everything does on that page.
 */
namespace App
{
    public partial class Modify : Form
    {
        public Modify(InHousePart inhousepart)
        {
            // If the object is an inhousePart then it will populate the page as an inhousepart.
            InitializeComponent();
            id_txtbox.Text = inhousepart.PartID.ToString();
            name_txtbox.Text = inhousepart.Name.ToString();
            inventory_txtbox.Text = inhousepart.InStock.ToString();
            price_cost_txtbox.Text = inhousepart.Price.ToString().Remove(0, 1); // The .Remove(0, 1) is to remove the $ from the price textbox.
            max_txtbox.Text = inhousepart.Max.ToString();
            min_txtbox.Text = inhousepart.Min.ToString();
            changable_txtbox.Text = inhousepart.MachineID.ToString();
        }
        public Modify(OutsourcedPart outsourced)
        {
            // If the object is an outsourcedPart then it will populate the page as an outsourcedPart.
            InitializeComponent();
            id_txtbox.Text = outsourced.PartID.ToString();
            name_txtbox.Text = outsourced.Name.ToString();
            inventory_txtbox.Text = outsourced.InStock.ToString();
            price_cost_txtbox.Text = outsourced.Price.ToString().Remove(0, 1); // The .Remove(0, 1) is to remove the $ from the price textbox.
            max_txtbox.Text = outsourced.Max.ToString();
            min_txtbox.Text = outsourced.Min.ToString();
            changable_txtbox.Text = outsourced.CompanyName.ToString();

            outsourced_radiobtn.Checked = true;
            inhouse_radiobtn.Checked = false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // Copy and paste from the save_btn_click from Add Part with a few minor adjustments.

            // Using these variables to check the add Part screen.
            int id;
            string name;
            int inventory;
            decimal price;
            int max;
            int min;
            string changable;

            // Prevent the program from crashing due to inaccurate inputs
            try
            {
                // Collecting the data from the text boxes.
                id = int.Parse(id_txtbox.Text);
                name = name_txtbox.Text;
                inventory = int.Parse(inventory_txtbox.Text);
                price = decimal.Parse(price_cost_txtbox.Text);
                max = int.Parse(max_txtbox.Text);
                min = int.Parse(min_txtbox.Text);
                changable = changable_txtbox.Text;

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

                if (inhouse_radiobtn.Checked && !int.TryParse(changable_txtbox.Text, out tryparse) || changable_txtbox.Text == "")
                {
                    changable_txtbox.BackColor = Color.Red;
                }
                else { changable_txtbox.BackColor = Color.White; }

                MessageBox.Show("ERROR: Please fill out or fix the highlighted fields.");
                return; // Stop from closing the screen. Makes the user change the values.

            }

            if (inhouse_radiobtn.Checked) // Still needs inhouse and outsourced code
            {

                try
                {
                    InHousePart newPart = new InHousePart(id, name, inventory, price, max, min, int.Parse(changable));
                    Inventory.updatePart(id, newPart);
                }
                catch (Exception ex)
                {
                    int tryparse;
                    if ( !int.TryParse(changable, out tryparse) )
                    {
                        changable_txtbox.BackColor = Color.Red;
                        MessageBox.Show("Error: Please fill out or fix the highlighted field");
                    }
                    return;
                }
                
                // Creating Base Part

            }
            else
            {
                // Creating Base Part
                Part newPart = new OutsourcedPart(id, name, inventory, price, max, min, changable);
                Inventory.updatePart(id, newPart);

            }

            Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inhouse_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            changing_lbl.Text = "Machine ID";
        }

        private void outsourced_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            changing_lbl.Text = "Company Name";
        }
    }
}
