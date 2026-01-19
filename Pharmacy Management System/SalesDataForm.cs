using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class SalesDataForm : Form
    {
        db database = new db();   // use db class

        public SalesDataForm()
        {
            InitializeComponent();
        }

        private void LoadSalesDataCommand(string searchValue = "")
        {
            try
            {
                string query = "SELECT * FROM SalesData";

                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    int id;
                    if (int.TryParse(searchValue, out id))
                    {
                        query += " WHERE OrderId LIKE '%" + searchValue + "%'";
                    }
                    else
                    {
                        query += " WHERE UserName LIKE '%" + searchValue + "%'";
                    }
                }

                DataTable dt = database.readAll(query);

                dgvSalesData.AutoGenerateColumns = true;
                dgvSalesData.DataSource = dt;
                dgvSalesData.Refresh();
                dgvSalesData.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message);
            }
        }

        private void SalesDataForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Hide();

            txtCurrentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

            LoadSalesDataCommand();

            float revenue = 0;
            for(int i = 0; i < dgvSalesData.Rows.Count; i++)
            {
                {
                    revenue += float.Parse(dgvSalesData.Rows[i].Cells["Total"].Value.ToString());
                }
            }
            txtRevenue.Text = revenue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSalesDataCommand(txtSearchBox.Text);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadSalesDataCommand();
        }

        private void SalesDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            
            if(UserHelper.UserRole == "Manager")
            {
                this.Visible = false;
                Manager_DB manager_DB = new Manager_DB();
                manager_DB.Visible = true;
                manager_DB.Show();
            }else if(UserHelper.UserRole == "admin")
            {
                this.Visible = false;
                Dashboard dash = new Dashboard();
                dash.Visible = true;
                dash.Show();
            }
            else
            {
                    this.Visible = false;
                    StaffDB staffDasboard = new StaffDB();
                    staffDasboard.Visible = true;
                    staffDasboard.Show();
                }
        }
    }
}
