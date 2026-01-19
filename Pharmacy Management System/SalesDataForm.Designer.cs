namespace Pharmacy_Management_System
{
    partial class SalesDataForm
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
            this.dgvSalesData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalesData
            // 
            this.dgvSalesData.AllowUserToAddRows = false;
            this.dgvSalesData.AllowUserToDeleteRows = false;
            this.dgvSalesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesData.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesData.Name = "dgvSalesData";
            this.dgvSalesData.ReadOnly = true;
            this.dgvSalesData.RowHeadersWidth = 51;
            this.dgvSalesData.RowTemplate.Height = 24;
            this.dgvSalesData.Size = new System.Drawing.Size(927, 344);
            this.dgvSalesData.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.txtRevenue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.txtCurrentDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 94);
            this.panel1.TabIndex = 0;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(685, 61);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(127, 22);
            this.txtRevenue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Revenue :";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(818, 54);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(100, 37);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(268, 53);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(102, 33);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(376, 61);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(170, 22);
            this.txtSearchBox.TabIndex = 4;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(73, 57);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(189, 22);
            this.txtCurrentDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sales DashBoard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSalesData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 344);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales DashBoard";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.OliveDrab;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(818, 11);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 37);
            this.btBack.TabIndex = 9;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // SalesDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "SalesDataForm";
            this.Text = "SalesDataForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesDataForm_FormClosed);
            this.Load += new System.EventHandler(this.SalesDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBack;
    }
}