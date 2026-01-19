namespace demo_project_tutorial
{
    partial class SalesPageForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.salesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.PayBtn = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.salesBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 532);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // salesBtn
            // 
            this.salesBtn.BackColor = System.Drawing.Color.Lime;
            this.salesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.Location = new System.Drawing.Point(1229, 3);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(94, 74);
            this.salesBtn.TabIndex = 22;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = false;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.newBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtReturn);
            this.panel1.Controls.Add(this.Return);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPaid);
            this.panel1.Controls.Add(this.PayBtn);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 74);
            this.panel1.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(417, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(369, 22);
            this.txtUserName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "UserName :";
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.Lime;
            this.newBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(792, 4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(102, 38);
            this.newBtn.TabIndex = 21;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Paid :";
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(645, 11);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(141, 22);
            this.txtReturn.TabIndex = 19;
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(564, 7);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 25);
            this.Return.TabIndex = 18;
            this.Return.Text = "Return";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total :";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(417, 9);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(141, 22);
            this.txtPaid.TabIndex = 16;
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.Lime;
            this.PayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.Location = new System.Drawing.Point(235, 0);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(102, 38);
            this.PayBtn.TabIndex = 15;
            this.PayBtn.Text = "Pay";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(78, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(151, 22);
            this.txtAmount.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 446);
            this.panel2.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1220, 446);
            this.dgvProducts.TabIndex = 0;
            // 
            // SalesPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SalesPageForm";
            this.Text = "SalesPageForm";
            this.Load += new System.EventHandler(this.SalesPageForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}