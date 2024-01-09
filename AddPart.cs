using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // Using these variables to check the add Part screen.
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
                name = name_txtbox.Text;
                inventory = int.Parse(inventory_txtbox.Text);
                price = decimal.Parse(price_cost_txtbox.Text);
                max = int.Parse(max_txtbox.Text);
                min = int.Parse(min_txtbox.Text);
                changable = changable_txtbox.Text;

                // Making sure max is larger than min.
                if (max < min)
                {
                    // This changes the background color of the min and max text boxes to red.
                    max_txtbox.BackColor = Color.Red;
                    min_txtbox.BackColor = Color.Red;
                    MessageBox.Show("The Max value cannot be smaller than Min"); // Throws an error messagebox 
                    return;
                } else
                {
                    // This changes the background color of the min and max text boxes to White. Only noticable if you fixed your mistake but created a new one.
                    max_txtbox.BackColor = Color.White;
                    min_txtbox.BackColor = Color.White;
                }
                if (inventory > max || inventory < min)
                {
                    // This changes the background color of the Inventory Text box to Red.
                    inventory_txtbox.BackColor = Color.Red;
                    MessageBox.Show("Inventory's value has to be between Max and Min's value"); // Throws an error messagebox 
                    return;
                } else { inventory_txtbox.BackColor = Color.White; }// This changes the background color of the inventory text box to White. Only noticable if you fixed your mistake but created a new one.


            }
            catch
            {
                /* Checking to see which fields have errors. 
                 * If any of these conditions are met, it will change that specific text box red.
                 * If you fix some of the errors but still have others, then the text boxes will turn white.
                 */

                int tryparse; // This is a variable to help check if the parses work in the textboxes.
                decimal mtryparse; // m - tryparse for decimal.

                if (name_txtbox.Text is not String || name_txtbox.Text == "") // Verifying that what is inputted is a string and is not blank.
                {
                    name_txtbox.BackColor = Color.Red; // Changes the text box to red.
                }
                else { name_txtbox.BackColor = Color.White; } // This will turn back to white if you correc the error but create a new one elsewhere.

                if (inventory_txtbox.Text == "" || !int.TryParse(inventory_txtbox.Text, out tryparse)) // Verifying that the textbox is not blank and making sure that it is a number using the tryParse
                {
                    inventory_txtbox.BackColor = Color.Red;// Changes the text box to red.

                }
                else { inventory_txtbox.BackColor = Color.White; }

                if (price_cost_txtbox.Text == "" || !decimal.TryParse(price_cost_txtbox.Text, out mtryparse)) // Verifying that the textbox is not blank and making sure that it is a number using the tryParse. Since this is a decimal value, I needed to use a decimal out variable.
                {
                    price_cost_txtbox.BackColor = Color.Red; // Changes the text box to red.
                }
                else { price_cost_txtbox.BackColor = Color.White; }

                if (max_txtbox.Text == "" || !int.TryParse(max_txtbox.Text, out tryparse))// Verifying that the textbox is not blank and making sure that it is a number using the tryParse
                {
                    max_txtbox.BackColor = Color.Red; // Changes the text box to red.
                }
                else { max_txtbox.BackColor = Color.White; }

                if (min_txtbox.Text == "" || !int.TryParse(min_txtbox.Text, out tryparse))// Verifying that the textbox is not blank and making sure that it is a number using the tryParse
                {
                    min_txtbox.BackColor = Color.Red; // Changes the text box to red.
                }
                else { min_txtbox.BackColor = Color.White; }

                if (inhouse_radiobtn.Checked && !int.TryParse(changable_txtbox.Text, out tryparse) || changable_txtbox.Text == "") // Verifying that if the inhouse radio button is checked, that the value is an integer OR it is not empty. 
                {
                    changable_txtbox.BackColor = Color.Red; // Changes the text box to red.
                }
                else { changable_txtbox.BackColor = Color.White; }

                MessageBox.Show("ERROR: Please fill out or fix the highlighted fields."); // If any of the above conditions are met, this error will pop up.
                return; // Stop from closing the screen. Makes the user change the values.

            }

            if (inhouse_radiobtn.Checked) // If the inhouse radio button is checked, it will create an inhouse part.
            {
                try
                {
                    InHousePart newPart = new InHousePart(Inventory.AllParts.Count + 1, name, inventory, price, max, min, int.Parse(changable)); // Changable is used as the machine id here, Hense being parsed to an Integer value.
                    Inventory.addPart(newPart);
                }
                catch (Exception ex)
                {
                    int tryparse;
                    if (!int.TryParse(changable, out tryparse))
                    {
                        changable_txtbox.BackColor = Color.Red;
                        MessageBox.Show("Error: Please fill out or fix the highlighted field");
                    }
                    return;
                }
                // Creating Base Part

            }
            else // Since the inhouse radio button isn't checked, we know it has to be the outsourced. So an outsourced part is created.
            {
                // Creating Base Part
                Part newPart = new OutsourcedPart(Inventory.AllParts.Count + 1, name, inventory, price, max, min, changable); // Changable is used as company name string here
                Inventory.addPart(newPart);

            }

            Close();
        }

        private void outsourced_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            changing_lbl.Text = "Company Name"; // Changing the Label based on the radio buttons conditions.
        }

        private void inhouse_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            changing_lbl.Text = "Machine ID"; // Changing the Label based on the radio buttons conditions.
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close(); // Closing the page if the user hits cancel.
        }
    }
}
