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
            this.labellogin = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.BackColor = System.Drawing.Color.Transparent;
            this.labellogin.Location = new System.Drawing.Point(143, 116);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(233, 16);
            this.labellogin.TabIndex = 1;
            this.labellogin.Text = "Sign in using username and password";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.BackColor = System.Drawing.Color.Transparent;
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.ForeColor = System.Drawing.Color.Black;
            this.lbusername.Location = new System.Drawing.Point(42, 186);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(94, 20);
            this.lbusername.TabIndex = 2;
            this.lbusername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(42, 284);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(91, 20);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(46, 219);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(413, 29);
            this.txbUsername.TabIndex = 4;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(46, 317);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(413, 29);
            this.txbPassword.TabIndex = 5;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.Info;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Black;
            this.btLogin.Location = new System.Drawing.Point(407, 434);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(84, 36);
            this.btLogin.TabIndex = 9;
            this.btLogin.Text = "Log in";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLogin.Location = new System.Drawing.Point(130, 22);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(242, 94);
            this.lblLogin.TabIndex = 22;
            this.lblLogin.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Pharmacy_Management_System.Properties.Resources.Gemini_Generated_Image_ymskukymskukymsk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.labellogin);
            this.Name = "LoginForm";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lblLogin;
    }
}

