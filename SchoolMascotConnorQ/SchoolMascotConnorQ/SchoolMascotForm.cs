/*
 * Created by: Connor Quinlan
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - School Mascot
 * This program displays the school name and mascot of each in the menu strip.
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

namespace SchoolMascotConnorQ
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }

        private void mniStMarks_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Lisgar";
            lblMascot.Text = "Lords";
        }

        private void mniInterSchoolOfMalaysia_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "International School of Malaysia";
            lblMascot.Text = "Eagles";
        }

        private void mniInterSchoolOfKenya_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "International School of Kenya";
            lblMascot.Text = "Lions";
        }
    }
}
