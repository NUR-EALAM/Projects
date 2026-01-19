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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            DataRow dr = newdb.read("select * from user_data where Ename='" + uname + "' and Epassword='" + pass + "'" );
            Console.WriteLine(dr);

            if (dr != null)
            {
                // Store role as string
                string Role = dr["Erole"].ToString();
                UserHelper.UserRole = Role;  // Assign to UserHelper

                Console.WriteLine("User role: " + Role);
            }
            else
            {
                MessageBox.Show("No user found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


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

            
            else if (dr != null)
            {
                this.Visible = false;
                Manager_DB manager_DB = new Manager_DB();
                manager_DB.Visible = true;
                manager_DB.Show();
                MessageBox.Show("Login successful- Manager", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (dr != null)
            {
                this.Visible = false;
                StaffDB staffDasboard = new StaffDB();
                staffDasboard.Visible = true;
                staffDasboard.Show();
                MessageBox.Show("Login successful- Staff", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dr == null)
            {
                MessageBox.Show("No user Found", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
