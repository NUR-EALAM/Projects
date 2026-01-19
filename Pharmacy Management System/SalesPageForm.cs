
using Pharmacy_Management_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_project_tutorial
{
    public partial class SalesPageForm : Form
    {
        db database = new db();
        public SalesPageForm()
        {
            InitializeComponent();
        }
        private int CalculateTotal()
        {
            int totalPrice = 0;

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.IsNewRow) continue;

                bool isSelected = row.Cells["chk"].Value != null &&
                                  Convert.ToBoolean(row.Cells["chk"].Value);

                if (isSelected)
                {
                    int price = Convert.ToInt32(row.Cells["MedPrice"].Value);
                    int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

                    totalPrice += price * qty;
                }
            }

            return totalPrice;
        }


        private void LoadProductsInfoCommand(string searchValue = "")
        {
            try
            {
                string query = "SELECT * FROM Medicine";

                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query += " WHERE MedName LIKE '%" + searchValue + "%'";
                }
                DataTable dt = database.readAll(query);


                dgvProducts.DataSource = dt;
                dgvProducts.Refresh();
                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message);
            }
        }


        //*******page load  ******
        private void SalesPageForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Hide();//it will hide SatffDB as its parent

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Select";
            chk.Name = "chk";
            dgvProducts.Columns.Insert(0, chk);
            LoadProductsInfoCommand();



            //quantity
            DataGridViewTextBoxColumn quantityCol = new DataGridViewTextBoxColumn();
            quantityCol.Name= "Quantity";
            quantityCol.HeaderText = "Quantity";
            quantityCol.ValueType = typeof(int);
            dgvProducts.Columns.Add(quantityCol);
            //plusbtn
            DataGridViewButtonColumn plusBtnCol = new DataGridViewButtonColumn();
            plusBtnCol.Name = "Plus";
            plusBtnCol.HeaderText = "+";
            plusBtnCol.Text = "+";
            plusBtnCol.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Add(plusBtnCol);
            //minus btn
            DataGridViewButtonColumn minusBtnCol = new DataGridViewButtonColumn();
            minusBtnCol.Name ="Minus";
            minusBtnCol.HeaderText = "-";
            minusBtnCol.Text = "-";
            minusBtnCol.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Add(minusBtnCol);

            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellValueChanged += dgvSelection_CellValueChanged;
            dgvProducts.CurrentCellDirtyStateChanged += dgvSelection_CurrentCellDirtyStateChanged;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                row.Cells["Quantity"].Value = 1;
            }


        }
        private void dgvSelection_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProducts.IsCurrentCellDirty)
            {
                dgvProducts.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvSelection_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts.Columns["chk"].Index || dgvProducts.Columns[e.ColumnIndex].Name == "Quantity")
            {
                txtAmount.Text = CalculateTotal().ToString();
            }
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||  e.ColumnIndex < 0) return;

            bool isSelected = dgvProducts.Rows[e.RowIndex].Cells["chk"].Value != null &&
                      Convert.ToBoolean(dgvProducts.Rows[e.RowIndex].Cells["chk"].Value);

            if ((dgvProducts.Columns[e.ColumnIndex].Name == "Plus" ||
         dgvProducts.Columns[e.ColumnIndex].Name == "Minus") && !isSelected)
            {
                MessageBox.Show("Please select the product first");
                return;
            }

            if (dgvProducts.Columns[e.ColumnIndex].Name == "Plus")
            {
                int qty = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["Quantity"].Value);
                dgvProducts.Rows[e.RowIndex].Cells["Quantity"].Value = qty + 1;
            }

            if (dgvProducts.Columns[e.ColumnIndex].Name == "Minus")
            {
                int qty = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["Quantity"].Value);
                if (qty > 1)
                    dgvProducts.Rows[e.RowIndex].Cells["Quantity"].Value = qty - 1;
            }

            txtAmount.Text = CalculateTotal().ToString();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtPaid.Text = "";
            txtReturn.Text = "";
        }


     

//sales Data page
        private void salesBtn_Click(object sender, EventArgs e)
        {
            SalesDataForm salesDataForm = new SalesDataForm();
            salesDataForm.Show(this);
        }
        //pay button
        private void PayBtn_Click(object sender, EventArgs e)
        {
            int totalAmount = CalculateTotal();

            int Total = totalAmount;
            string UserName = txtUserName.Text;
            DateTime PurchaseDate = DateTime.Now;
            txtAmount.Text = totalAmount.ToString();
          

            int paidAmount;
            if (!int.TryParse(txtPaid.Text, out paidAmount))
            {
                MessageBox.Show("Please enter a valid paid amount");
                return;
            }

            if (paidAmount < totalAmount)
            {
                MessageBox.Show("Paid amount is less than total amount");
                return;
            }

            int returnAmount = paidAmount - totalAmount;
            txtReturn.Text = returnAmount.ToString();
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("User Name is required"); return;
            }
        
          
            string query = "INSERT INTO SalesData (UserName, PurchaseDate, Total) VALUES (@UserName, @PurchaseDate, @Total)";
            try
            {

                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=PharmacyDB;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);//passing query to DB
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@PurchaseDate", SqlDbType.DateTime).Value = PurchaseDate;
                cmd.Parameters.Add("@Total", SqlDbType.Int).Value = Total;
                cmd.ExecuteNonQuery();//will be used to update,delete and insert only as it never returns anything
                MessageBox.Show("Purchased Successful!");

                //update quantity in Medicine table
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.IsNewRow) continue;
                    bool isSelected = row.Cells["chk"].Value != null &&
                                      Convert.ToBoolean(row.Cells["chk"].Value);
                    if (isSelected)
                    {
                        int medId = Convert.ToInt32(row.Cells["MedId"].Value);
                        int purchasedQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                        string updateQuery = "UPDATE Medicine SET MedQuantity = MedQuantity - @PurchasedQty WHERE MedId = @MedId";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.Add("@PurchasedQty", SqlDbType.Int).Value = purchasedQty;
                        updateCmd.Parameters.Add("@MedId", SqlDbType.Int).Value = medId;
                        updateCmd.ExecuteNonQuery();
                    }
                }





                con.Close();
                txtAmount.Text = "";
                txtPaid.Text = "";
                txtUserName.Text = "";
                txtReturn.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: DB realted error!" + ex.Message);
            }
        }


        private void newBtn_Click_1(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtPaid.Text = "";
            txtUserName.Text = "";
            txtReturn.Text = "";
        }
    }
}
