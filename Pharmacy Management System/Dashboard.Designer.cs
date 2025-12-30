namespace Pharmacy_Management_System
{
    partial class Dashboard
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
            this.btStaff = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btMedecine = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.butadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStaff
            // 
            this.btStaff.BackColor = System.Drawing.SystemColors.Info;
            this.btStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStaff.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btStaff.Location = new System.Drawing.Point(110, 354);
            this.btStaff.Name = "btStaff";
            this.btStaff.Size = new System.Drawing.Size(164, 59);
            this.btStaff.TabIndex = 1;
            this.btStaff.Text = "Staff";
            this.btStaff.UseVisualStyleBackColor = false;
            this.btStaff.Click += new System.EventHandler(this.btStaff_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLogout.Location = new System.Drawing.Point(834, 482);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(95, 41);
            this.btLogout.TabIndex = 16;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btMedecine
            // 
            this.btMedecine.BackColor = System.Drawing.SystemColors.Info;
            this.btMedecine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMedecine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMedecine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btMedecine.Location = new System.Drawing.Point(668, 354);
            this.btMedecine.Name = "btMedecine";
            this.btMedecine.Size = new System.Drawing.Size(145, 60);
            this.btMedecine.TabIndex = 19;
            this.btMedecine.Text = "Medecine";
            this.btMedecine.UseVisualStyleBackColor = false;
            this.btMedecine.Click += new System.EventHandler(this.btMedecine_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLogo.Location = new System.Drawing.Point(333, 33);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(274, 94);
            this.lblLogo.TabIndex = 21;
            this.lblLogo.Text = "Admin";
            // 
            // butadd
            // 
            this.butadd.BackColor = System.Drawing.SystemColors.Info;
            this.butadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butadd.Location = new System.Drawing.Point(403, 354);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(145, 60);
            this.butadd.TabIndex = 22;
            this.butadd.Text = "ADD";
            this.butadd.UseVisualStyleBackColor = false;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 535);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btMedecine);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btStaff);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStaff;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btMedecine;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button butadd;
    }
}