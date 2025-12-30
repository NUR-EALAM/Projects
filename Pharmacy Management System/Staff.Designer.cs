namespace Pharmacy_Management_System
{
    partial class StaffForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.Label();
            this.lbSerach = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btSEARCH = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(42, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.lbSname_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(42, 107);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 20);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoSize = true;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.Location = new System.Drawing.Point(42, 146);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(76, 20);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.Text = "Category";
            this.cmbCategory.Click += new System.EventHandler(this.lbAddress_Click);
            // 
            // lbSerach
            // 
            this.lbSerach.AutoSize = true;
            this.lbSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerach.Location = new System.Drawing.Point(42, 220);
            this.lbSerach.Name = "lbSerach";
            this.lbSerach.Size = new System.Drawing.Size(62, 20);
            this.lbSerach.TabIndex = 3;
            this.lbSerach.Text = "Serach";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(42, 35);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(31, 20);
            this.lbId.TabIndex = 4;
            this.lbId.Text = " ID";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(42, 182);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 20);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Price";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(146, 33);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(216, 22);
            this.txbId.TabIndex = 6;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(146, 180);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(216, 22);
            this.txbPassword.TabIndex = 7;
            // 
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(146, 105);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(216, 22);
            this.txbGender.TabIndex = 8;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(146, 218);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(216, 22);
            this.txbPhone.TabIndex = 10;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(146, 68);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(216, 22);
            this.txbName.TabIndex = 11;
            // 
            // btDelete
            // 
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.ForeColor = System.Drawing.Color.Navy;
            this.btDelete.Location = new System.Drawing.Point(555, 146);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(84, 36);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.ForeColor = System.Drawing.Color.Navy;
            this.btEdit.Location = new System.Drawing.Point(555, 89);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(84, 36);
            this.btEdit.TabIndex = 13;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.Navy;
            this.btSave.Location = new System.Drawing.Point(555, 33);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(84, 36);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStaff.Location = new System.Drawing.Point(46, 269);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(673, 169);
            this.dgvStaff.TabIndex = 15;
            // 
            // btSEARCH
            // 
            this.btSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSEARCH.ForeColor = System.Drawing.Color.Navy;
            this.btSEARCH.Location = new System.Drawing.Point(555, 204);
            this.btSEARCH.Name = "btSEARCH";
            this.btSEARCH.Size = new System.Drawing.Size(84, 36);
            this.btSEARCH.TabIndex = 16;
            this.btSEARCH.Text = "Serach";
            this.btSEARCH.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tablet",
            "Antibiotic",
            "Antiseptics"});
            this.comboBox1.Location = new System.Drawing.Point(150, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Category";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btSEARCH);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbGender);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbSerach);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lbName);
            this.Name = "StaffForm";
            this.Text = "ADD ITEM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label cmbCategory;
        private System.Windows.Forms.Label lbSerach;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btSEARCH;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}