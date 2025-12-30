using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy_Management_System
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.Visible = true;
            loginForm.Show();
            this.Close();
        }
        db newdb = new db();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string number = txtNumber.Text;
            string address = txtAddress.Text;
            string tital = cmbTitel.Text;
            if (txtID.Text == null || txtName.Text == null || txtNumber == null || txtAddress == null || cmbTitel.Text == null)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "insert into staff (id, name , number, address, tital) values ('" + id + "  ','" + name + "','" + number + "', '" + address + "''" + tital + "')";
                newdb.write(query);
                MessageBox.Show("staff added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
