using System.Linq;
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

        private DataProvider() { }

        //private string connectionStr = "Data Source=ADMIN;Initial Catalog=StudyManagementApp;Integrated Security=True";
        private string connectionStr = @"Data Source=DESKTOP-K3KS644\SQLEXPRESS;Initial Catalog=StudyManagementApp;User ID=sa;Password=123456";
        //private string connectionStr = @"Data Source=DESKTOP-OI8ITQQ\SQLEXPRESS;Initial Catalog=StudyManagementApp;Integrated Security=True";
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
