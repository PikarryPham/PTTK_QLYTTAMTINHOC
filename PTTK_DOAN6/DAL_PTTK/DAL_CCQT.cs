using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_PTTK
{
    public class DAL_CCQT
    {
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
       
        public static Int32 PTTK_KiemTraTonTaiTenCCQT(string tenccqt)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            int isValid = 0;
            try
            {
                string query = @"SELECT [dbo].[PTTK_KiemTraTonTaiTenCCQT](@TENCCQT);";
                ///define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, con);
                //parameter value will be set from command line
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@TENCCQT";
                param1.SqlDbType = SqlDbType.NVarChar;
                param1.Value = tenccqt;

                //pass parameter to the SQL Command
                cmd.Parameters.Add(param1);
                //open connection
                con.Open();

                //execute the SQLCommand
                Int32 functionResult = (Int32)cmd.ExecuteScalar();
                isValid = functionResult;
            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return isValid;
        }
    }
}
