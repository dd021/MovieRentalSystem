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
    public partial class MovieOperations : Form
    {
        private DBOperation db;
        private DataTable table;
        int movie_id;

        public MovieOperations()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            table = new DataTable();
            db = new DBOperation();
            LoadGridData();            
        }

        private void LoadGridData()
        {
            table.Clear();
            table = db.PrepareMovieDataTable();
            gridMovie.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            string title = textMovieTitle.Text.Trim();
            string release_year_string = textReleaseYear.Text.Trim();
            string genre = textGenreName.Text.Trim();
            float rating = (float)numericRating.Value;
            if(Validation.IsEmpty(title) || Validation.IsEmpty(release_year_string) || Validation.IsEmpty(genre))
            {
                message = "Please Fill All Boxes";
            }
            else if(release_year_string.Length != 4 && !Validation.IsNumber(release_year_string))
            {
                message = "Invalid Release Year Given";
            }   
            else
            {
                int release_year = int.Parse(release_year_string);
                float rental_cost = 5;
                if (release_year < DateTime.Now.Year - 5)
                {
                    rental_cost = 2;
                }
                if (db.SaveMovie(title, rating, release_year, genre, rental_cost))
                {
                    message = "Movie Details are Saved in Database";
                    LoadGridData();
                    ResetForm();
                }
                else
                {
                    message = "No Movie Details are Saved in Database";
                }
            }
            MessageBox.Show(message);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (movie_id != 0)
            {
                string message = "";
                string title = textMovieTitle.Text.Trim();
                string release_year_string = textReleaseYear.Text.Trim();
                string genre = textGenreName.Text.Trim();
                float rating = (float)numericRating.Value;
                if (Validation.IsEmpty(title) || Validation.IsEmpty(release_year_string) || Validation.IsEmpty(genre))
                {
                    message = "Please Fill All Boxes";
                }
                else if (release_year_string.Length != 4 && Validation.IsNumber(release_year_string))
                {
                    message = "Invalid Release Year Given";
                }
                else
                {
                    int release_year = int.Parse(release_year_string);
                    float rental_cost = 5;
                    if (release_year < DateTime.Now.Year - 5)
                    {
                        rental_cost = 2;
                    }
                    if (db.SaveMovie(movie_id,title, rating, release_year, genre, rental_cost))
                    {
                        message = "Movie Details are Updated in Database";
                        LoadGridData();
                    }
                    else
                    {
                        message = "No Movie Details are Saved in Database";
                    }
                }
                MessageBox.Show(message);
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                ResetForm();
            }
        }

        private void ResetForm()
        {
            movie_id = 0;
            textMovieTitle.Text = "";
            textReleaseYear.Text = "";
            numericRating.Value = 0;
            textGenreName.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (movie_id != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Remove Movie Details?", "Movie Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if (db.RemoveMovie(movie_id))
                    {
                        message = "Movie Details are Removed from Database";
                        LoadGridData();
                    }
                    else
                    {
                        message = "No Movie Details Removed from Database";
                    }
                    MessageBox.Show(message);
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    ResetForm();
                }
            }
        }

        private void MovieOperations_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseConnection();
        }

        private void gridMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                movie_id = int.Parse(gridMovie.Rows[e.RowIndex].Cells[0].Value.ToString());
                textMovieTitle.Text = gridMovie.Rows[e.RowIndex].Cells[1].Value.ToString();                
                textGenreName.Text = gridMovie.Rows[e.RowIndex].Cells[2].Value.ToString();
                numericRating.Value = int.Parse(gridMovie.Rows[e.RowIndex].Cells[3].Value.ToString());
                textReleaseYear.Text = gridMovie.Rows[e.RowIndex].Cells[5].Value.ToString();
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
