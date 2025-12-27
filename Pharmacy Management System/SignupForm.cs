using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    //.\SQLEXPRESS;Initial Catalog = PharmacyDB; Integrated Security = True; Encrypt=False
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }


        private void btCreateaccount_Click(object sender, EventArgs e)
        {
            string uname = txtbName.Text;
            string pass = txtbPassword.Text;
            string repass = txtbRetype.Text;
            string email = txtbEmail.Text;
            string phone = txtbPhone.Text;
            if (pass != repass)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPassword.Clear();
            }
            else if ((uname[0] == '_' || uname[0] == '.' || uname[0] == '-') ||
             (uname[uname.Length - 1] == '_' || uname[uname.Length - 1] == '.' || uname[uname.Length - 1] == '-'))
            {
                MessageBox.Show("Username cannot start or end with special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbName.Clear();
            }
            else if (uname == null || pass == null || email == null || phone == null || repass == null)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (uname.Length < 5)
            {
                MessageBox.Show("Username must be at least 5 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbName.Clear();
            }
            else if (char.IsDigit(uname[0]))
            {
                MessageBox.Show("Username cannot start with a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbName.Clear();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(uname, @"[_\.\-]{2,}"))
            {
                MessageBox.Show("Username cannot contain consecutive special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbName.Clear();
            }
            else if (phone.ToString().Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPhone.Clear();
            }
            else if (email.Contains(" "))
            {
                MessageBox.Show("Email cannot contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbEmail.Clear();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbEmail.Clear();
            }
            else if (pass.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPassword.Clear();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(pass, @"[A-Z]"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPassword.Clear();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(pass, @"[0-9]"))
            {
                MessageBox.Show("Password must contain at least one digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPassword.Clear();
            }
            else if (pass.Contains(" "))
            {
                MessageBox.Show("Password cannot contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPassword.Clear();
            }
            else
            {
                db database = new db();
                string query = $"INSERT INTO user_data VALUES ('{uname}', '{email}', '{phone}', '{pass}')";
                int result = database.write(query);
                if (result > 0)
                {
                    MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    LoginForm login = new LoginForm();
                    login.Visible = true;
                }
                else
                {
                    MessageBox.Show("Failed to create account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}