using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_PTTK
{
    public class DataConnection
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=.;Database=xxxxx;Integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
