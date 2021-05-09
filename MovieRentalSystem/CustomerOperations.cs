using MovieRentalSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class CustomerOperations : Form
    {
        public DBOperation db;
        DataTable table;
        int cust_id;

        public CustomerOperations()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            db = new DBOperation();
            table = new DataTable();
            LoadGridData();
        }

        private void LoadGridData()
        {
            table.Clear();
            table = db.PrepareCustomerDataTable();
            gridCustomer.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            string first_name = textFirstName.Text.Trim();
            string last_name = textLastName.Text.Trim();
            string phone = textPhoneNo.Text.Trim();
            string address = textAddress.Text.Trim();
            if (Validation.IsEmpty(first_name) || Validation.IsEmpty(last_name) || Validation.IsEmpty(phone) || Validation.IsEmpty(address))
            {
                message = "Please Fill All Boxes";
            }
            else if (!Validation.IsValidPhone(phone))
            {
                message = "Invalid Phone Given";
            }
            else
            {
                if (db.SaveCustomer(first_name,last_name,address,phone))
                {
                    message = "Customer Details are Saved in Database";
                    LoadGridData();
                    ResetForm();
                }
                else
                {
                    message = "No Customer Details are Saved in Database";
                }
            }
            MessageBox.Show(message);
        }

        private void ResetForm()
        {
            cust_id = 0;
            textFirstName.Text = "";
            textLastName.Text = "";
            textAddress.Text = "";
            textPhoneNo.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cust_id != 0)
            {
                string message = "";
                string first_name = textFirstName.Text.Trim();
                string last_name = textLastName.Text.Trim();
                string phone = textPhoneNo.Text.Trim();
                string address = textAddress.Text.Trim();
                if (Validation.IsEmpty(first_name) || Validation.IsEmpty(last_name) || Validation.IsEmpty(phone) || Validation.IsEmpty(address))
                {
                    message = "Please Fill All Boxes";
                }
                else if (!Validation.IsValidPhone(phone))
                {
                    message = "Invalid Phone Given";
                }
                else
                {
                    if (db.SaveCustomer(cust_id,first_name, last_name, address, phone))
                    {
                        message = "Customer Details are Updated in Database";
                        LoadGridData();
                    }
                    else
                    {
                        message = "No Customer Details are Updated in Database";
                    }
                }
                MessageBox.Show(message);
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                ResetForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cust_id != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Remove Customer Details?", "Video Rental Software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if (db.RemoveCustomer(cust_id))
                    {
                        message = "Customer Details are Removed from Database";
                        cust_id = 0;
                        LoadGridData();
                    }
                    else
                    {
                        message = "No Customer Details Removed from Database";
                    }
                    MessageBox.Show(message);
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    ResetForm();
                }
            }
        }

        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cust_id = int.Parse(gridCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                textFirstName.Text = gridCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                textLastName.Text = gridCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                textAddress.Text = gridCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                textPhoneNo.Text = gridCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
