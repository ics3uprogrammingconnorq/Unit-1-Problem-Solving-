/*
 * Created by: Connor Quinlan
 * Created on: 20-02-2019(My Birthday)
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 Circumference
 * This program takes an input radius and calculates circumference. Then displays it on screen.
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

namespace CircumferenceConnorQ
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double PI = Math.PI;
            double radius = Convert.ToDouble(txtInput.Text);
            double circumference = Math.Round(2 * radius * PI*100)/100;
            lblOutput.Text = "This is the circumference of the circle: " + circumference;
            lblOutput.Visible = true;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Visible = false;
        }
    }
}
