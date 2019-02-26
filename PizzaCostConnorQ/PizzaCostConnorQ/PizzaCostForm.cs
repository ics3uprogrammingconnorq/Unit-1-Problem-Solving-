/*
 * Created by: Connor Quinlan
 * Created on: 22-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pizza Cost
 * This program calculates the price of a pizza based on given diameter.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostConnorQ
{
    public partial class frmPizzaCost : Form
    {
        // Declair Variables
        double diameter = 5;
        double subtotal;
        double total;

        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate and diplay price
            subtotal = diameter * 0.5 + 0.75 + 0.99;
            total = subtotal * 1.13;
            subtotal = Math.Round(subtotal * 100) / 100;
            total = Math.Round(total * 100) / 100;
            lblSubtotal.Text = "Subtotal: $" + Convert.ToString(subtotal);
            lblTotal.Text = "Total: $" + Convert.ToString(total);
        }

        private void lstInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When box is changed set diameter and reset prices
            diameter = Convert.ToDouble(lstInput.SelectedItem);
            lblSubtotal.Text = "?";
            lblTotal.Text = "?";
        }
    }
}
