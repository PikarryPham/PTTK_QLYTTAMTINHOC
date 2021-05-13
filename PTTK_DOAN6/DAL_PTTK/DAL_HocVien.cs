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
    public class DAL_HocVien
    {
        //public static Int32 PTTK_KiemTraThongTinTonTaiHV(string cmndhocvien) { return 1; };
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static DataTable PTTK_LayDSHocVien()
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_LayDSHocVien", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param_RETURNCODE;
                SqlParameter param_RETURNMESSAGE;
                param_RETURNCODE = cmd.Parameters.Add("@RETURNCODE", SqlDbType.Int);
                param_RETURNCODE.Direction = ParameterDirection.Output;
                param_RETURNMESSAGE = cmd.Parameters.Add("@RETURNMESS", SqlDbType.NVarChar, 500);
                param_RETURNMESSAGE.Direction = ParameterDirection.Output;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);

                //cmd.ExecuteNonQuery();

                ReturnCode = Convert.ToInt32(param_RETURNCODE.Value.ToString());
                ReturnMess = param_RETURNMESSAGE.Value.ToString();
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
            return tbl;
        }

        public static Int32 PTTK_LayIDHocVien(string cmnd)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            int idHocVien = 0;
            try
            {
                string query = @"SELECT [dbo].[PTTK_LayIDHocVien](@CMND);";
                ///define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, con);
                //parameter value will be set from command line
                SqlParameter param0 = new SqlParameter();
                param0.ParameterName = "@CMND";
                param0.SqlDbType = SqlDbType.VarChar;
                param0.Value = cmnd;


                //pass parameter to the SQL Command
                cmd.Parameters.Add(param0);
                
                //open connection
                con.Open();

                //execute the SQLCommand
                Int32 functionResult = (Int32)cmd.ExecuteScalar();
                idHocVien = functionResult;
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
            return idHocVien;
        }
    }
}
