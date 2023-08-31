using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Dinesh Adhikari
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Dinesh Adhikari
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Decimal subTotal;
            Decimal salesTax;
            Decimal orderTotal;
            Decimal addOnPrice = 0;

            if (radHamburger.Checked)
            {
                Decimal hamburgerPrice = 6.95m;

                if (chbx1.Checked)
                {
                    addOnPrice += .75m;
                }
                if (chbx2.Checked)
                {
                    addOnPrice += .75m;

                }
                if (chbx3.Checked)
                {
                    addOnPrice += .75m;
                }

                subTotal = hamburgerPrice + addOnPrice;
                txtSubtotal.Text = subTotal.ToString("C");

                salesTax = subTotal * (7.75m / 100);
                txtSalesTax.Text = salesTax.ToString("C");

                orderTotal = subTotal + salesTax;
                txtOrderTotal.Text = orderTotal.ToString("C");

            }

            if (radPizza.Checked)
            {
                Decimal pizzaPrice = 5.95m;

                if (chbx1.Checked)
                {
                    addOnPrice += .50m;
                }
                if (chbx2.Checked)
                {
                    addOnPrice += .50m;

                }
                if (chbx3.Checked)
                {
                    addOnPrice += .50m;
                }

                subTotal = pizzaPrice + addOnPrice;
                txtSubtotal.Text = subTotal.ToString("C");

                salesTax = subTotal * (7.75m / 100);
                txtSalesTax.Text = salesTax.ToString("C");

                orderTotal = subTotal + salesTax;
                txtOrderTotal.Text = orderTotal.ToString("C");

            }

            if (radSalad.Checked)
            {
                Decimal saladPrice = 4.95m;

                if (chbx1.Checked)
                {
                    addOnPrice += .25m;
                }
                if (chbx2.Checked)
                {
                    addOnPrice += .25m;

                }
                if (chbx3.Checked)
                {
                    addOnPrice += .25m;
                }

                subTotal = saladPrice + addOnPrice;
                txtSubtotal.Text = subTotal.ToString("C");

                salesTax = subTotal * (7.75m / 100);
                txtSalesTax.Text = salesTax.ToString("C");

                orderTotal = subTotal + salesTax;
                txtOrderTotal.Text = orderTotal.ToString("C");

            }

        }

        private void ClearTotals()
        {
            txtSubtotal.Clear();
            txtSalesTax.Clear();
            txtOrderTotal.Clear();

        }

        private void ClearAddOns()
        {
            chbx1.Checked = false;
            chbx2.Checked = false;
            chbx3.Checked = false;


        }

        // Dinesh Adhikari
        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();

            gbxAddOn.Text = "Add-on items ($.50/each)";

            chbx1.Text = "Pepperoni";
            chbx2.Text = "Sausage";
            chbx3.Text = "Olives";

        }
        // Dinesh Adhikari
        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();

            gbxAddOn.Text = "Add-on items ($.75/each)";

            chbx1.Text = "Lettuce, tomato, and onions";
            chbx2.Text = "Ketchup, mustard, and mayo";
            chbx3.Text = "French Fries";


        }
        // Dinesh Adhikari
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();

            gbxAddOn.Text = "Add-on items ($.25/each)";

            chbx1.Text = "Croutons";
            chbx2.Text = "Bacons bits";
            chbx3.Text = "Bread sticks";
        }

        // Dinesh Adhikari
        private void chbx1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }


        // Dinesh Adhikari
        private void chbx2_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        // Dinesh Adhikari
        private void chbx3_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
    }
}
