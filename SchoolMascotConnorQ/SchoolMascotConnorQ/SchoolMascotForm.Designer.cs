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
            this.mniInterSchoolOfMalaysia = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInterSchoolOfKenya = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblMascot = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mnuSchools.SuspendLayout();
            this.grbSchool.SuspendLayout();
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
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniInterSchoolOfMalaysia
            // 
            this.mniInterSchoolOfMalaysia.Name = "mniInterSchoolOfMalaysia";
            this.mniInterSchoolOfMalaysia.Size = new System.Drawing.Size(245, 22);
            this.mniInterSchoolOfMalaysia.Text = "International School Of Malaysia";
            this.mniInterSchoolOfMalaysia.Click += new System.EventHandler(this.mniInterSchoolOfMalaysia_Click);
            // 
            // mniInterSchoolOfKenya
            // 
            this.mniInterSchoolOfKenya.Name = "mniInterSchoolOfKenya";
            this.mniInterSchoolOfKenya.Size = new System.Drawing.Size(245, 22);
            this.mniInterSchoolOfKenya.Text = "International School Of Kenya";
            this.mniInterSchoolOfKenya.Click += new System.EventHandler(this.mniInterSchoolOfKenya_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(245, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblMascot);
            this.grbSchool.Controls.Add(this.lblSchool);
            this.grbSchool.Location = new System.Drawing.Point(57, 110);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(741, 258);
            this.grbSchool.TabIndex = 1;
            this.grbSchool.TabStop = false;
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(40, 155);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(33, 37);
            this.lblMascot.TabIndex = 1;
            this.lblMascot.Text = "?";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(40, 42);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(33, 37);
            this.lblSchool.TabIndex = 0;
            this.lblSchool.Text = "?";
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 521);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot By Connor Quinlan";
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniInterSchoolOfMalaysia;
        private System.Windows.Forms.ToolStripMenuItem mniInterSchoolOfKenya;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.Label lblSchool;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

