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
    public partial class Manager_DB : Form
    {
        public Manager_DB()
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

        private void butMedecine_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MedecineForm medecineForm = new MedecineForm();
            medecineForm.Visible = true;
            medecineForm.Show();
            this.Close();
        }
    }
}
