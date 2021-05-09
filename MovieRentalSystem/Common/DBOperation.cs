using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem.Common
{
    public class DBOperation : ConnectionLayer
    {
        public bool SaveMovie(string title, float rating, int release_year, string genre_name, float rental_cost)
        {
            string query = "insert into movies(title,rating,release_year,genre_name,rental_cost) values(@title,@rating,@release_year,@genre_name,@rental_cost)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@title", title);
            parameters.Add("@rating", rating);
            parameters.Add("@release_year", release_year);
            parameters.Add("@genre_name", genre_name);
            parameters.Add("@rental_cost", rental_cost);
            return ExecuteNonQuery(query, parameters);
        }

        public bool SaveMovie(int movie_id, string title, float rating, int release_year, string genre_name, float rental_cost)
        {

            string query = "update movies set title=@title,rating=@rating,release_year=@release_year,genre_name=@genre_name,rental_cost=@rental_cost where movie_id = @movie_id ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@title", title);
            parameters.Add("@rating", rating);
            parameters.Add("@release_year", release_year);
            parameters.Add("@genre_name", genre_name);
            parameters.Add("@rental_cost", rental_cost);
            parameters.Add("@movie_id", movie_id);
            return ExecuteNonQuery(query, parameters);
        }

        public bool RemoveMovie(int movie_id)
        {
            string query = "delete from movies where movie_id = @movie_id ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@movie_id", movie_id);
            return ExecuteNonQuery(query, parameters);
        }

        public DataSet GetAllMovies()
        {
            string query = "select movie_id,title,rating,rental_cost,release_year,genre_name from movies";
            return ExecuteQueryForDataSet(query);
        }
        
        public float GetRentCostOfMovie(int movie_id)
        {
            float rental_cost = 0;
            try
            {
                string query = "select rental_cost from movies where movie_id = @movie_id";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@movie_id", movie_id);
                DataSet ds = ExecuteQueryForDataSet(query, parameters);
                if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    rental_cost = float.Parse(ds.Tables[0].Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
            }
            return rental_cost;
        }

        public bool SaveCustomer(string first_name, string last_name, string address, string phone_no)
        {
            string query = "insert into customer(first_name,last_name,address,phone_no) values(@first_name,@last_name,@address,@phone_no)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@first_name", first_name);
            parameters.Add("@last_name", last_name);
            parameters.Add("@address", address);
            parameters.Add("@phone_no", phone_no);
            return ExecuteNonQuery(query, parameters);
        }

        public bool SaveCustomer(int cust_id, string first_name, string last_name, string address, string phone_no)
        {
            string query = "update customer set first_name=@first_name,last_name=@last_name,address=@address,phone_no=@phone_no  where cust_id = @cust_id ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@first_name", first_name);
            parameters.Add("@last_name", last_name);
            parameters.Add("@address", address);
            parameters.Add("@phone_no", phone_no);
            parameters.Add("@cust_id", cust_id);
            return ExecuteNonQuery(query, parameters);
        }

        public bool RemoveCustomer(int cust_id)
        {
            string query = "delete from customer where cust_id = @cust_id ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@cust_id", cust_id);
            return ExecuteNonQuery(query, parameters);
        }

        public DataSet GetAllCustomer()
        {
            string query = "select * from customer";
            return ExecuteQueryForDataSet(query);
        }

        public DataTable ViewAllCustomer()
        {            
            string query = "select * from vwAllCustomer ";
            DataTable dt = ExecuteQueryForDataTable(query);
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Select Any Customer" };
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }

        public DataTable ViewAllMovie()
        {
           string query = "select * from vwAllMovie ";
            DataTable dt = ExecuteQueryForDataTable(query);
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Select Any Movie" };
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }

        public bool RentMovieToCustomer(int movie_id, int cust_id, float rented_cost, DateTime date_rented)
        {
            string query = "insert into rented_movies(movie_id,cust_id,rented_cost,date_rented,date_returned) values(@movie_id,@cust_id,@rented_cost,@date_rented,null)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@movie_id", movie_id);
            parameters.Add("@cust_id", cust_id);
            parameters.Add("@rented_cost", rented_cost);
            parameters.Add("@date_rented", date_rented);
            return ExecuteNonQuery(query, parameters);
        }

        public DataSet GetRentedMovieDetails()
        {
            string query = "prcDisplayRentedMovies";
            return ExecuteSelectProcedure(query);
        }

        public DataSet GetRentedOutMovieDetails()
        {
            string query = "prcDisplayRentedOutMovies";
            return ExecuteSelectProcedure(query);            
        }

        public bool ReturnMovie(int rent_id, DateTime date_returned)
        {
            string query = "update rented_movies set date_returned = @date_returned where rent_id = @rent_id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@date_returned", date_returned);
            parameters.Add("@rent_id", rent_id);
            return ExecuteNonQuery(query, parameters);
        }


        public bool RemoveRentedDetails(int rent_id)
        {
            string query = "delete from rented_movies where rent_id = @rent_id ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@rent_id", rent_id);
            return ExecuteNonQuery(query, parameters);
        }

        public DataTable PrepareMovieDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Movie ID");
            table.Columns.Add("Movie Title");
            table.Columns.Add("Genre Name");
            table.Columns.Add("Rating");
            table.Columns.Add("Rental Cost");
            table.Columns.Add("Release Year");
            DataSet ds = GetAllMovies();
            if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    table.Rows.Add(row["movie_id"], row["title"], row["genre_name"], row["rating"], row["rental_cost"], row["release_year"]);
                }
            }            
            return table;
        }

        public DataTable PrepareCustomerDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Customer ID");
            table.Columns.Add("First Name");
            table.Columns.Add("Last Name");
            table.Columns.Add("Address");
            table.Columns.Add("Phone No");
            DataSet ds = GetAllCustomer();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    table.Rows.Add(row["cust_id"], row["first_name"], row["last_name"], row["address"], row["phone_no"]);
                }
            }
            return table;
        }

        public DataTable PrepareRentedDataTable(bool rent)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Rent ID");
            table.Columns.Add("Customer Name");
            table.Columns.Add("Address");
            table.Columns.Add("Phone No");
            table.Columns.Add("Movie Title");
            table.Columns.Add("Rented Cost");
            table.Columns.Add("Rented Date");
            table.Columns.Add("Return Date");
            DataSet ds = GetRentedMovieDetails();
            if(rent)
            {
                ds = GetRentedOutMovieDetails();
            }
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    table.Rows.Add(row["rent_id"], row["name"], row["address"], row["phone_no"], row["title"], row["rented_cost"], row["date_rented"], row["date_returned"]);
                }
            }
            return table;
        }

    }
}
