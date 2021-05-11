using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public static class MyExtensions
    {
        public static SqlCommand CreateCommandAndOpenConnection(string query, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(query, connection);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            return command;
        }
    }
}
