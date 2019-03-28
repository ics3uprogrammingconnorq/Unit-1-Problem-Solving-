/*
 * Created by: Connor Quinlan
 * Created on: 28-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Perimeter and Area
 * This program calculates area and perimeter based on width and length inputs.
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

namespace AreaPerimeterConnorQ
{
    public partial class frmAreaPerimeter : Form
    {
        public frmAreaPerimeter()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length, width, area, perimeter;

            // assign length and width to inputs
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            // calculate perimeter and area
            area = length * width;
            perimeter = (2 * width) + (2 * length);

            // display perimeter and area
            this.lblArea.Text = "Area = " + Convert.ToString(area) + " meters squared";
            this.lblPerimeter.Text = "Perimeter = " + Convert.ToString(perimeter) + " meters";
            lblArea.Visible = true;
            lblPerimeter.Visible = true;
        }
    }
}
