namespace Pharmacy_Management_System
{
    partial class Manager_DB
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
            this.butMedecine = new System.Windows.Forms.Button();
            this.lblManager = new System.Windows.Forms.Label();
            this.btSales = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butMedecine
            // 
            this.butMedecine.BackColor = System.Drawing.SystemColors.Info;
            this.butMedecine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMedecine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMedecine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butMedecine.Location = new System.Drawing.Point(253, 436);
            this.butMedecine.Name = "butMedecine";
            this.butMedecine.Size = new System.Drawing.Size(145, 60);
            this.butMedecine.TabIndex = 26;
            this.butMedecine.Text = " Add Medecine";
            this.butMedecine.UseVisualStyleBackColor = false;
            this.butMedecine.Click += new System.EventHandler(this.butMedecine_Click);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblManager.Location = new System.Drawing.Point(307, 42);
            this.lblManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(364, 94);
            this.lblManager.TabIndex = 25;
            this.lblManager.Text = "Manager";
            // 
            // btSales
            // 
            this.btSales.BackColor = System.Drawing.SystemColors.Info;
            this.btSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSales.Location = new System.Drawing.Point(644, 436);
            this.btSales.Name = "btSales";
            this.btSales.Size = new System.Drawing.Size(145, 60);
            this.btSales.TabIndex = 24;
            this.btSales.Text = "View Sales";
            this.btSales.UseVisualStyleBackColor = false;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLogout.Location = new System.Drawing.Point(907, 587);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(95, 41);
            this.btLogout.TabIndex = 23;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // Manager_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 650);
            this.Controls.Add(this.butMedecine);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.btSales);
            this.Controls.Add(this.btLogout);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "Manager_DB";
            this.Text = "Manager_DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butMedecine;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btSales;
        private System.Windows.Forms.Button btLogout;
    }
}