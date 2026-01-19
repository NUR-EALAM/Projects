using demo_project_tutorial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Dashboard : Form
    {
        string id = "P-";

        public Dashboard()
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

        private void btMedecine_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MedecineForm medecineForm = new MedecineForm();
            medecineForm.Visible = true;
            medecineForm.Show();
            this.Close();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmployeeAdd add = new EmployeeAdd();
            add.Visible = true;
            add.Show();
            this.Close();
        }

        private void butseles_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SalesDataForm salesDataForm = new SalesDataForm();  
            salesDataForm.Visible = true;
            salesDataForm.Show();
            this.Close();
        }
    }
}