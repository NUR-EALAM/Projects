using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            string uname = txbUsername.Text;
            string pass = txbPassword.Text;

            db newdb = new db();
            DataRow dr = newdb.read("select * from user_data where name='" + uname + "' and password='" + pass + "'");
            Console.WriteLine(dr);
            if (uname == "" || pass == "")
            {
                MessageBox.Show("Fill the feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPassword.Clear();
            }
            else if (uname == "admin" && pass == "admin")
            {
                this.Visible = false;
                Dashboard dash = new Dashboard();
                dash.Visible = true;
                MessageBox.Show("Login successful- admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else  if (dr != null)
            {
                this.Visible = false;
                Manager_DB manager_DB= new Manager_DB();
                manager_DB.Visible = true;
                manager_DB.Show();
               // MessageBox.Show("Login successful- Stuff", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (dr == null)
            {
                MessageBox.Show("No user Found", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
 
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignupForm signupForm = new SignupForm();
            signupForm.Visible = true;
            signupForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
