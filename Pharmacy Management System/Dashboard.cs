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


        private void Form1_Load(object sender, EventArgs e)
        {
            db newdb = new db();
            string count = newdb.read("select count(*) from PID")[0].ToString();
            this.id += (Int32.Parse(count) + 1).ToString("D4");
            label1.Text = this.id;
        }
        private void ClearAll()
        {
            this.numericUpDown1.Value = 0;
            this.numericUpDown2.Value = 0;
            this.cmbCatagory.SelectedIndex = -1;
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
    }
}