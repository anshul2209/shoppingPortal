using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace eShopee2.Classes
{
    public class Database
    {
        static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Anshul\Desktop\eShopee2\eShopee2\App_Data\Database1.mdf;Integrated Security=True;User Instance=True";

        SqlConnection connection = new SqlConnection(connectionString);

        public Database()
        {
            connection.Open();
        }

        public int setData(string queryString)
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            return command.ExecuteNonQuery();
        }

        public SqlDataReader getData(string queryString)
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                return reader;

            else
            {
                reader.Close();
                return null;
            }
        }

        public void close()
        {
            connection.Close();
        }
    }
}  n
