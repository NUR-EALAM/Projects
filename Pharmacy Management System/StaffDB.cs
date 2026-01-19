using demo_project_tutorial;
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
    public partial class StaffDB : Form
    {
        public StaffDB()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.Visible = true;
            loginForm.Show();
            this.Close();
        }

        private void butSell_Click(object sender, EventArgs e)
        {
            SalesPageForm salesPageForm = new SalesPageForm();
            salesPageForm.Show(this);
            // this.Hide();
        }

    

        private void btSales_Click(object sender, EventArgs e)
        {
            SalesDataForm salesDataForm = new SalesDataForm();
           salesDataForm.Show(Owner);
        }
    }
}
