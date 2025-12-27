namespace Pharmacy_Management_System
{
    partial class MedecineForm
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
            this.btSEARCH = new System.Windows.Forms.Button();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.SuspendLayout();
            // 
            // btSEARCH
            // 
            this.btSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSEARCH.ForeColor = System.Drawing.Color.Navy;
            this.btSEARCH.Location = new System.Drawing.Point(575, 194);
            this.btSEARCH.Name = "btSEARCH";
            this.btSEARCH.Size = new System.Drawing.Size(84, 36);
            this.btSEARCH.TabIndex = 33;
            this.btSEARCH.Text = "Serach";
            this.btSEARCH.UseVisualStyleBackColor = true;
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(66, 259);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.ReadOnly = true;
            this.dgvMed.RowHeadersWidth = 51;
            this.dgvMed.RowTemplate.Height = 24;
            this.dgvMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMed.Size = new System.Drawing.Size(617, 169);
            this.dgvMed.TabIndex = 32;
            this.dgvMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMed_CellContentClick);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.Navy;
            this.btSave.Location = new System.Drawing.Point(575, 23);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(84, 36);
            this.btSave.TabIndex = 31;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEdit
            // 
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.ForeColor = System.Drawing.Color.Navy;
            this.btEdit.Location = new System.Drawing.Point(575, 79);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(84, 36);
            this.btEdit.TabIndex = 30;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.ForeColor = System.Drawing.Color.Navy;
            this.btDelete.Location = new System.Drawing.Point(575, 136);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(84, 36);
            this.btDelete.TabIndex = 29;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(166, 58);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(216, 22);
            this.txbName.TabIndex = 28;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(166, 134);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(216, 22);
            this.txbPrice.TabIndex = 26;
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(166, 95);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(216, 22);
            this.txbQuantity.TabIndex = 25;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(62, 25);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(45, 20);
            this.lbType.TabIndex = 21;
            this.lbType.Text = "Type";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(62, 136);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 20);
            this.lbPrice.TabIndex = 19;
            this.lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(62, 97);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(71, 20);
            this.lbQuantity.TabIndex = 18;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(62, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 20);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "Name";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(166, 23);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(216, 24);
            this.cmbType.TabIndex = 34;
            // 
            // MedecineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btSEARCH);
            this.Controls.Add(this.dgvMed);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbName);
            this.Name = "MedecineForm";
            this.Text = "MedecineForm";
            this.Load += new System.EventHandler(this.MedecineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSEARCH;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridView dgvMed;
    }
}