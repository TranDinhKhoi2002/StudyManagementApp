using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;

namespace StudyManagementApp.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        { 
            get
            {
                if(instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }
            private set => instance = value; 
        }

        private DataProvider()
        {
            //string databaseDir = System.IO.Directory.GetCurrentDirectory();
            //databaseDir = databaseDir.Remove(databaseDir.IndexOf("bin\\Debug")) + "Database\\Database.mdf";

            //connectionStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+databaseDir+";Integrated Security=True";

            connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\Github\StudyManagementApp\StudyManagementApp\StudyManagementApp\Database\Database.mdf;Integrated Security=True;";
        }

        private string connectionStr;
        //private string connectionStr = "Data Source=ADMIN;Initial Catalog=StudyManagementApp;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (var item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (var item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (var item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
