using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccess
{
     public class DataConnection
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = @"Data Source=DESKTOP-6OFEFL5\SQLEXPRESS;Initial Catalog=QLTINHOC_PTTK;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
