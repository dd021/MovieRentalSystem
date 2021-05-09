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
    public partial class MovieRentOperations : Form
    {
        public DBOperation db;
        DataTable table;
        int rent_id;

        public MovieRentOperations()
        {
            InitializeComponent();
            db = new DBOperation();
            table = new DataTable(); 
            LoadGridData();
            PrepareComboDetails();
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadGridData()
        {
            table.Clear();
            table = db.PrepareRentedDataTable(radioOut.Checked);
            gridRent.DataSource = table;
        }

        private void PrepareComboDetails()
        {
            DataTable tableCustomer = db.ViewAllCustomer();
            comboCustomer.ValueMember = "cust_id";
            comboCustomer.DisplayMember = "name";
            comboCustomer.DataSource = tableCustomer;
            DataTable tableMovie = db.ViewAllMovie();
            comboMovie.ValueMember = "movie_id";
            comboMovie.DisplayMember = "title";
            comboMovie.DataSource = tableMovie;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            string message = "";
            if (comboCustomer.SelectedIndex == 0 || comboMovie.SelectedIndex == 0)
            {
                message = "Please Select All Value";
            }
            else 
            {
                float rental_cost = float.Parse(labelRent.Text.Trim());
                int movie_id = int.Parse(comboMovie.SelectedValue.ToString());
                int cust_id = int.Parse(comboCustomer.SelectedValue.ToString());
                if (db.RentMovieToCustomer(movie_id, cust_id, rental_cost, pickerIssueDate.Value))
                {
                    message = "Movie is Issued";
                    LoadGridData();
                    ResetForm();
                }
                else
                {
                    message = "No Movie is Issued";
                }
            }
            MessageBox.Show(message);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (rent_id != 0)
            {
                if (db.ReturnMovie(rent_id, DateTime.Now))
                {
                    MessageBox.Show("Movie is Successfuly returned");
                    LoadGridData();
                }
                else
                {
                    MessageBox.Show("No Movie is Returned");
                }
                ResetForm();
                btnReturn.Enabled = false;
                btnDelete.Enabled = false;
                btnIssue.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rent_id != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Remove Movie Rent Details?", "Movie Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if (db.RemoveRentedDetails(rent_id))
                    {
                        message = "Movie Rented Details are Removed from Database";
                        rent_id = 0;
                        LoadGridData();
                    }
                    else
                    {
                        message = "No Movie Rented Details are Removed from Database";
                    }
                    MessageBox.Show(message);
                    btnReturn.Enabled = false;
                    btnDelete.Enabled = false;
                    btnIssue.Enabled = true;
                }
            }
        }

        private void gridRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rent_id = int.Parse(gridRent.Rows[e.RowIndex].Cells[0].Value.ToString());
                string customer_name = gridRent.Rows[e.RowIndex].Cells[1].Value.ToString();
                string movie_title = gridRent.Rows[e.RowIndex].Cells[4].Value.ToString();
                DateTime rent_date;
                if(DateTime.TryParse(gridRent.Rows[e.RowIndex].Cells[5].Value.ToString(),out rent_date))
                {
                    pickerIssueDate.Value = rent_date;
                }
                int selected_index = 0;
                for(int index = 0; index < comboCustomer.Items.Count; index++)
                {
                    if(comboCustomer.Items[0].ToString().Equals(customer_name) )
                    {
                        selected_index = index;
                    }
                    index++;
                }
                comboCustomer.SelectedIndex = selected_index;
                selected_index = 0;
                for (int index = 0; index < comboMovie.Items.Count; index++)
                {
                    if (comboMovie.Items[0].ToString().Equals(movie_title))
                    {
                        selected_index = index;
                    }
                    index++;
                }
                comboMovie.SelectedIndex = selected_index;
                btnReturn.Enabled = true;
                btnDelete.Enabled = true;
                btnIssue.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void radioOut_CheckedChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void comboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMovie.SelectedIndex != 0)
            {
                labelRent.Text = db.GetRentCostOfMovie(int.Parse(comboMovie.SelectedValue.ToString())).ToString();
            }
            else
            {
                labelRent.Text = "None";
            }
        }


        private void ResetForm()
        {
            rent_id = 0;
            comboCustomer.SelectedIndex = 0;
            comboMovie.SelectedIndex = 0;
            labelRent.Text = "None";
            pickerIssueDate.Value = DateTime.Now;
        }
    }
}
