using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem.Common
{
    public class ConnectionLayer
    {
        protected SqlConnection conn;

        public ConnectionLayer()
        {
            conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=moviesrent;Integrated Security=True;");
            conn.Open();
        }

        public bool CheckConnectionState()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        public void CloseConnection()
        {
            if (CheckConnectionState())
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public bool ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                foreach(var parameter in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet ExecuteQueryForDataSet(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }
        public DataSet ExecuteQueryForDataSet(string query, Dictionary<string, object> parameters)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

        public DataTable ExecuteQueryForDataTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        public DataSet ExecuteSelectProcedure(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }
    }
}
