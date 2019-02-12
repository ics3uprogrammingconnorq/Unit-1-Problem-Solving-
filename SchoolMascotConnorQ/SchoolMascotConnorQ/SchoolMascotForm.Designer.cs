namespace SchoolMascotConnorQ
{
    partial class frmSchoolMascot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStMarks = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInterSchoolOfMalaysia = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInterSchoolOfKenya = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSchools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(849, 24);
            this.mnuSchools.TabIndex = 0;
            this.mnuSchools.Text = "menuStrip1";
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniStMarks,
            this.mniInterSchoolOfMalaysia,
            this.mniInterSchoolOfKenya,
            this.mniExit});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(245, 22);
            this.mniImmaculata.Text = "Immaculata";
            // 
            // mniStMarks
            // 
            this.mniStMarks.Name = "mniStMarks";
            this.mniStMarks.Size = new System.Drawing.Size(245, 22);
            this.mniStMarks.Text = "St.Marks";
            // 
            // mniInterSchoolOfMalaysia
            // 
            this.mniInterSchoolOfMalaysia.Name = "mniInterSchoolOfMalaysia";
            this.mniInterSchoolOfMalaysia.Size = new System.Drawing.Size(245, 22);
            this.mniInterSchoolOfMalaysia.Text = "International School Of Malaysia";
            // 
            // mniInterSchoolOfKenya
            // 
            this.mniInterSchoolOfKenya.Name = "mniInterSchoolOfKenya";
            this.mniInterSchoolOfKenya.Size = new System.Drawing.Size(245, 22);
            this.mniInterSchoolOfKenya.Text = "International School Of Kenya";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(245, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 521);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot By Connor Quinlan";
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniStMarks;
        private System.Windows.Forms.ToolStripMenuItem mniInterSchoolOfMalaysia;
        private System.Windows.Forms.ToolStripMenuItem mniInterSchoolOfKenya;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

