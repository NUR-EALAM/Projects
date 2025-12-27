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
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.txbAdress = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSEARCH = new System.Windows.Forms.Button();
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
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(42, 107);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(64, 20);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "Gender";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(42, 146);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(71, 20);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Address";
            this.lbAddress.Click += new System.EventHandler(this.lbAddress_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(42, 220);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(82, 20);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Phone No";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(42, 35);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 20);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "ID";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(42, 182);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(83, 20);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(146, 33);
            this.txbId.Name = "txbId";
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
            // txbAdress
            // 
            this.txbAdress.Location = new System.Drawing.Point(146, 144);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(216, 22);
            this.txbAdress.TabIndex = 9;
            this.txbAdress.TextChanged += new System.EventHandler(this.txbAdress_TextChanged);
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
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
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
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSEARCH);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbAdress);
            this.Controls.Add(this.txbGender);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbName);
            this.Name = "StaffForm";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.TextBox txbAdress;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btSEARCH;
    }
}