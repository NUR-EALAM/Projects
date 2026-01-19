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
        db newdb = new db();

        public EmployeeAdd()
        {
            InitializeComponent();
            GenerateEmployeeID();
            txtID.ReadOnly = true;
            load_products();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard Dashboard = new Dashboard();
            Dashboard.Visible = true;
            Dashboard.Show();
            this.Close();
        }
        private void GenerateEmployeeID()
        {
            try
            {
                string query = "SELECT MAX(CAST(EId AS INT)) FROM user_data";
                DataTable dt = newdb.readAll(query);

                int nextId = 1;
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    nextId = Convert.ToInt32(dt.Rows[0][0]) + 1;
                }

                txtID.Text = nextId.ToString("D3"); 
            }
            catch
            {
                txtID.Text = "001";
            }
        }
        private bool ValidatePassword(string password)  
        {
            if (password.Length != 5)
            {
                MessageBox.Show("Password must be 5 characters (1 letter + 4 digits)\nExample: A1234", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!char.IsLetter(password[0]))
            {
                MessageBox.Show("Password must start with a letter\nExample: A1234", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int i = 1; i < password.Length; i++)
            {
                if (!char.IsDigit(password[i]))
                {
                    MessageBox.Show("Password must have 4 digits after the letter\nExample: A1234", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
        private bool ValidatePhoneNumber(string number)
        {
            if (number.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits\nExample: 01712345678", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!number.StartsWith("01"))
            {
                MessageBox.Show("Phone number must start with 01\nExample: 01712345678", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!number.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain only digits\nExample: 01712345678", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email cannot be empty", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with @gmail.com\nExample: user@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string localPart = email.Substring(0, email.IndexOf('@'));
            if (string.IsNullOrWhiteSpace(localPart))
            {
                MessageBox.Show("Email must have a username before @gmail.com\nExample: user@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EId = txtID.Text;
            string Ename = txtName.Text;
            string Enumber = txtNumber.Text;
            string Epassword = txtPassword.Text;
            string Eemail = txtEmail.Text;
            string Erole = cmbTitel.Text;
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(cmbTitel.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidatePassword(Epassword))
            {
                return;
            }
            if (!ValidatePhoneNumber(Enumber))
            {
                return;
            }
            if (!ValidateEmail(Eemail))
            {
                return;
            }
            string query = "INSERT INTO user_data (EId, Ename, Enumber, Epassword, Eemail, Erole) VALUES ('" + EId + "','" + Ename + "','" + Enumber + "','" + Epassword + "', '" + Eemail + "','" + Erole + "')";

            int result = newdb.write(query);

            if (result > 0)
            {
                MessageBox.Show("Staff added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                GenerateEmployeeID();
                load_products();
            }
            else
            {
                MessageBox.Show("Failed to add staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtNumber.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cmbTitel.SelectedIndex = -1;
        }

        private void load_products()
        {
            DataTable dt = newdb.readAll("SELECT * FROM user_data");
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvAdd.AutoGenerateColumns = true;
                dgvAdd.DataSource = dt;
                dgvAdd.Columns[0].HeaderText = "Id";
                dgvAdd.Columns[1].HeaderText = "Name";
                dgvAdd.Columns[2].HeaderText = "Number";
                dgvAdd.Columns[3].HeaderText = "Password";
                dgvAdd.Columns[4].HeaderText = "Email";
                dgvAdd.Columns[5].HeaderText = "Role";
            }
        }

        private void dgvAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdd.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtNumber.Text = row.Cells[2].Value.ToString();
                txtPassword.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                cmbTitel.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string EId = txtID.Text;

            if (string.IsNullOrWhiteSpace(EId))
            {
                MessageBox.Show("Please enter an Employee ID to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM user_data WHERE EId = '" + EId + "'";
                int deleteResult = newdb.write(query);

                if (deleteResult > 0)
                {
                    MessageBox.Show("Employee deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    GenerateEmployeeID();
                    load_products();
                }
                else
                {
                    MessageBox.Show("Employee not found or failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string EId = txtID.Text;

            if (string.IsNullOrWhiteSpace(EId))
            {
                load_products();
                MessageBox.Show("Employee list refreshed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM user_data WHERE EId = '" + EId + "'";
            DataTable dt = newdb.readAll(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                load_products();
                MessageBox.Show("Employee found and loaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchId = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter an Employee ID to search", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            string query = "SELECT * FROM user_data WHERE EId = '" + searchId + "'";
            DataTable dt = newdb.readAll(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                // Load data into form fields
                DataRow row = dt.Rows[0];
                txtID.Text = row["EId"].ToString();
                txtName.Text = row["Ename"].ToString();
                txtNumber.Text = row["Enumber"].ToString();
                txtPassword.Text = row["Epassword"].ToString();
                txtEmail.Text = row["Eemail"].ToString();
                cmbTitel.Text = row["Erole"].ToString();

                MessageBox.Show("Employee found and loaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Employee with ID '" + searchId + "' not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Clear();
                txtSearch.Focus();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string EId = txtID.Text;
            string Ename = txtName.Text;
            string Enumber = txtNumber.Text;
            string Epassword = txtPassword.Text;
            string Eemail = txtEmail.Text;
            string Erole = cmbTitel.Text;
            if (string.IsNullOrWhiteSpace(EId))
            {
                MessageBox.Show("Please search for an employee first before editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(cmbTitel.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidatePassword(Epassword))
            {
                return;
            }
            if (!ValidatePhoneNumber(Enumber))
            {
                return;
            }
            if (!ValidateEmail(Eemail))
            {
                return;
            }
            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to update this employee's information?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string query = "UPDATE user_data SET Ename = '" + Ename + "', Enumber = '" + Enumber + "', Epassword = '" + Epassword + "', Eemail = '" + Eemail + "', Erole = '" + Erole + "' WHERE EId = '" + EId + "'";

                int result = newdb.write(query);

                if (result > 0)
                {
                    MessageBox.Show("Employee data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_products(); 
                    ClearFields();
                    GenerateEmployeeID(); 
                }
                else
                {
                    MessageBox.Show("Failed to update employee. Employee ID may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {

        }
    }
}