using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BF6C0LE\SQLEXPRESS;Initial Catalog=DBPERSONELUDEMY;Integrated Security=True");
    }
}
