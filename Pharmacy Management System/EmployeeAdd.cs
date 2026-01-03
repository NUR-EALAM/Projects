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
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard Dashboard = new Dashboard();
            Dashboard.Visible = true;
            Dashboard.Show();
            this.Close();
        }
        db newdb = new db();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string EId = txtID.Text;
            string Ename = txtName.Text;
            string Enumber = txtNumber.Text;
            string Epassword = txtPassword.Text;
            string Eemail = txtEmail.Text;
            string Erole = cmbTitel.Text;
            if (txtID.Text == null || txtName.Text == null || txtNumber.Text == null || txtEmail.Text == null || cmbTitel.Text == null || txtPassword.Text == null )
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "insert into user_data (EId, Ename , Enumber, Epassword, Eemail, Erole) values ('" + EId + "','" + Ename + "','" + Enumber + "','" + Epassword + "', '" + Eemail + "','" + Erole + "')";
                newdb.write(query);
                MessageBox.Show("staff added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            load_products();


        }
        private void load_products()
        {
            DataTable dt = newdb.readAll("SELECT * FROM user_data");
            if (dt != null)
            {
                dgvAdd.AutoGenerateColumns = true;
                dgvAdd.DataSource = dt;
                dgvAdd.Columns[0].HeaderText = "Id";
                dgvAdd.Columns[1].HeaderText = "name";
                dgvAdd.Columns[2].HeaderText = "number";
                dgvAdd.Columns[2].HeaderText = "password";
                dgvAdd.Columns[3].HeaderText = "Email";
                dgvAdd.Columns[4].HeaderText = "Role";
            }

        }

        private void dgvAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_products();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string EId = txtID.Text;
            string query = "DELETE FROM user_data WHERE EId = '" + EId + "'";
            newdb.write(query);
            MessageBox.Show("Employee deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_products();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_products();
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {

        }

       
    }
}
