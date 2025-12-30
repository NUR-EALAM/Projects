namespace Pharmacy_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbLogin = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.llbForgot = new System.Windows.Forms.LinkLabel();
            this.btLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.Navy;
            this.lbLogin.Location = new System.Drawing.Point(28, 70);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(101, 38);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(32, 109);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(233, 16);
            this.labellogin.TabIndex = 1;
            this.labellogin.Text = "Sign in using username and password";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.ForeColor = System.Drawing.Color.Navy;
            this.lbusername.Location = new System.Drawing.Point(31, 151);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(94, 20);
            this.lbusername.TabIndex = 2;
            this.lbusername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Navy;
            this.lbPassword.Location = new System.Drawing.Point(31, 248);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(91, 20);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(35, 184);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(320, 29);
            this.txbUsername.TabIndex = 4;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(35, 283);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(320, 29);
            this.txbPassword.TabIndex = 5;
            // 
            // llbForgot
            // 
            this.llbForgot.AutoSize = true;
            this.llbForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbForgot.Location = new System.Drawing.Point(32, 488);
            this.llbForgot.Name = "llbForgot";
            this.llbForgot.Size = new System.Drawing.Size(162, 18);
            this.llbForgot.TabIndex = 6;
            this.llbForgot.TabStop = true;
            this.llbForgot.Text = "Forgot your password?";
            // 
            // btLogin
            // 
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.ForeColor = System.Drawing.Color.Navy;
            this.btLogin.Location = new System.Drawing.Point(271, 381);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(84, 36);
            this.btLogin.TabIndex = 9;
            this.btLogin.Text = "Log in";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.llbForgot);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.lbLogin);
            this.Name = "LoginForm";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.LinkLabel llbForgot;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

