using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_PTTK
{
    public class DAL_NgayThiKyThiCCQT
    {
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static int returnCode1 { get; set; }

        public static string returnMess1 { get; set; }
        public static DataTable PTTK_LayDanhSachCacNgayThiCCQT(int makithiccqt)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_LayDanhSachCacNgayThiCCQT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKYTHICCQT", SqlDbType.Int).Value = makithiccqt;

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
        public static DataTable PTTK_ThemNgayThiMoi(int makithiccqt, string ngaythimoi)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_ThemNgayThiMoi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKYTHICCQT", SqlDbType.Int).Value = makithiccqt;
                cmd.Parameters.Add("@NGAYTHIMOI", SqlDbType.Date).Value = ngaythimoi;

                SqlParameter param_RETURNCODE;
                SqlParameter param_RETURNMESSAGE;
                param_RETURNCODE = cmd.Parameters.Add("@RETURNCODE", SqlDbType.Int);
                param_RETURNCODE.Direction = ParameterDirection.Output;
                param_RETURNMESSAGE = cmd.Parameters.Add("@RETURNMESS", SqlDbType.NVarChar, 500);
                param_RETURNMESSAGE.Direction = ParameterDirection.Output;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);

                //cmd.ExecuteNonQuery();

                returnCode1 = Convert.ToInt32(param_RETURNCODE.Value.ToString());
                returnMess1 = param_RETURNMESSAGE.Value.ToString();
            }
            catch (Exception ex)
            {
                returnCode1 = 500;
                returnMess1 = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return tbl;
        }
        public static DataTable PTTK_XoaNgayThiHienTai(int makithiccqt, string ngaythimoi)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_XoaNgayThiHienTai", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKYTHICCQT", SqlDbType.Int).Value = makithiccqt;
                cmd.Parameters.Add("@NGAYTHIMOI", SqlDbType.Date).Value = ngaythimoi;

                SqlParameter param_RETURNCODE;
                SqlParameter param_RETURNMESSAGE;
                param_RETURNCODE = cmd.Parameters.Add("@RETURNCODE", SqlDbType.Int);
                param_RETURNCODE.Direction = ParameterDirection.Output;
                param_RETURNMESSAGE = cmd.Parameters.Add("@RETURNMESS", SqlDbType.NVarChar, 500);
                param_RETURNMESSAGE.Direction = ParameterDirection.Output;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);

                //cmd.ExecuteNonQuery();

                returnCode1 = Convert.ToInt32(param_RETURNCODE.Value.ToString());
                returnMess1 = param_RETURNMESSAGE.Value.ToString();
            }
            catch (Exception ex)
            {
                returnCode1 = 500;
                returnMess1 = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return tbl;
        }

        public static DataTable PTTK_CapNhatNgayThi(int makithiccqt, string ngaythicu, string ngaythimoi)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_CapNhatNgayThi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKYTHICCQT", SqlDbType.Int).Value = makithiccqt;
                cmd.Parameters.Add("@NGAYTHICU", SqlDbType.Date).Value = ngaythicu;
                cmd.Parameters.Add("@NGAYTHIMOI", SqlDbType.Date).Value = ngaythimoi;

                SqlParameter param_RETURNCODE;
                SqlParameter param_RETURNMESSAGE;
                param_RETURNCODE = cmd.Parameters.Add("@RETURNCODE", SqlDbType.Int);
                param_RETURNCODE.Direction = ParameterDirection.Output;
                param_RETURNMESSAGE = cmd.Parameters.Add("@RETURNMESS", SqlDbType.NVarChar, 500);
                param_RETURNMESSAGE.Direction = ParameterDirection.Output;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);

                //cmd.ExecuteNonQuery();

                returnCode1 = Convert.ToInt32(param_RETURNCODE.Value.ToString());
                returnMess1 = param_RETURNMESSAGE.Value.ToString();
            }
            catch (Exception ex)
            {
                returnCode1 = 500;
                returnMess1 = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return tbl;
        }

        public static Int32 PTTK_KiemTraMaKiThiCCQT(int makithiccqt)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            int isValid = 0;
            try
            {
                string query = @"SELECT [dbo].[PTTK_KiemTraMaKiThiCCQT](@MAKITHICCQT);";
                ///define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, con);
                //parameter value will be set from command line
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@MAKITHICCQT";
                param1.SqlDbType = SqlDbType.Int;
                param1.Value = makithiccqt;

                //pass parameter to the SQL Command
                cmd.Parameters.Add(param1);
                //open connection
                con.Open();

                //execute the SQLCommand
                Int32 functionResult = (Int32)cmd.ExecuteScalar();
                isValid = functionResult;
            }
            catch(Exception ex)
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
