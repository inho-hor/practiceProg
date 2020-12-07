using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regAndAuto
{
    class DB
    {
        static string connectionString = @"Data Source=LAPTOP-NLV085P5;Initial Catalog=practice;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
