using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        private static Database instance;
        public static Database Instance 
        {
            get { if (instance == null) instance = new Database(); return instance; } 
            private set => instance = value; 
        }
        private Database() { }

        private string strConnection = @"Data Source=.\sqlexpress;Initial Catalog=QL_QuanAo;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listParameter = query.Split(' ');
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listParameter = query.Split(' ');
                    foreach (string item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listParameter = query.Split(' ');
                    foreach (string item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
