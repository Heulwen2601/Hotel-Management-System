using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManager.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = @"Server=DaeSangHyeok;Initial Catalog=HotelManagement;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    AddParameter(query, parameter, command);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra.");
                }
            }
            return data;
        }
        public int ExecuteNoneQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    AddParameter(query, parameter, command);
                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = new object();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    AddParameter(query, parameter, command);
                    data = command.ExecuteScalar();
                    connection.Close();
                }
                return data;
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra.");
            }
            return data;
        }
        private void AddParameter(string query, object[] parameter, SqlCommand command)
        {
            if (parameter != null)
            {
                string[] listParameter = query.Split(' ');
                int i = 0;
                foreach (string item in listParameter)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        ++i;
                    }
                }
            }
        }
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }
        private DataProvider() { }
    }
}