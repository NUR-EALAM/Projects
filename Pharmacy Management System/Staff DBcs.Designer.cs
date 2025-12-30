namespace Pharmacy_Management_System
{
    partial class Staff_DBcs
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
            this.butSell = new System.Windows.Forms.Button();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btSales = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butSell
            // 
            this.butSell.BackColor = System.Drawing.SystemColors.Info;
            this.butSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butSell.Location = new System.Drawing.Point(222, 353);
            this.butSell.Name = "butSell";
            this.butSell.Size = new System.Drawing.Size(145, 60);
            this.butSell.TabIndex = 30;
            this.butSell.Text = " Sell Medecine";
            this.butSell.UseVisualStyleBackColor = false;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblStaff.Location = new System.Drawing.Point(362, 31);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(205, 94);
            this.lblStaff.TabIndex = 29;
            this.lblStaff.Text = "Staff";
            // 
            // btSales
            // 
            this.btSales.BackColor = System.Drawing.SystemColors.Info;
            this.btSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSales.Location = new System.Drawing.Point(613, 353);
            this.btSales.Name = "btSales";
            this.btSales.Size = new System.Drawing.Size(145, 60);
            this.btSales.TabIndex = 28;
            this.btSales.Text = "View Sales";
            this.btSales.UseVisualStyleBackColor = false;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLogout.Location = new System.Drawing.Point(840, 510);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(95, 41);
            this.btLogout.TabIndex = 27;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // Staff_DBcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 563);
            this.Controls.Add(this.butSell);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.btSales);
            this.Controls.Add(this.btLogout);
            this.Name = "Staff_DBcs";
            this.Text = "Staff_DBcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSell;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btSales;
        private System.Windows.Forms.Button btLogout;
    }
}