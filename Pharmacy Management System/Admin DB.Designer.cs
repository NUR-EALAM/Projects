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
            this.btEmployee = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btMedecine = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.butseles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEmployee
            // 
            this.btEmployee.BackColor = System.Drawing.SystemColors.Info;
            this.btEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btEmployee.Location = new System.Drawing.Point(86, 337);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(150, 60);
            this.btEmployee.TabIndex = 1;
            this.btEmployee.Text = "Employee";
            this.btEmployee.UseVisualStyleBackColor = false;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLogout.Location = new System.Drawing.Point(737, 469);
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
            this.btMedecine.Location = new System.Drawing.Point(641, 337);
            this.btMedecine.Name = "btMedecine";
            this.btMedecine.Size = new System.Drawing.Size(150, 60);
            this.btMedecine.TabIndex = 19;
            this.btMedecine.Text = "Medecine";
            this.btMedecine.UseVisualStyleBackColor = false;
            this.btMedecine.Click += new System.EventHandler(this.btMedecine_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLogo.Location = new System.Drawing.Point(284, 33);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(274, 94);
            this.lblLogo.TabIndex = 21;
            this.lblLogo.Text = "Admin";
            // 
            // butseles
            // 
            this.butseles.BackColor = System.Drawing.SystemColors.Info;
            this.butseles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butseles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butseles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butseles.Location = new System.Drawing.Point(369, 337);
            this.butseles.Name = "butseles";
            this.butseles.Size = new System.Drawing.Size(150, 60);
            this.butseles.TabIndex = 22;
            this.butseles.Text = "View Sales";
            this.butseles.UseVisualStyleBackColor = false;
            this.butseles.Click += new System.EventHandler(this.butseles_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.butseles);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btMedecine);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btEmployee);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btMedecine;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button butseles;
    }
}