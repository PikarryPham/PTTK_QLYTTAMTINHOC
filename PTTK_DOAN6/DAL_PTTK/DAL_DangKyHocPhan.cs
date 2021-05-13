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
    public class DAL_DangKyHocPhan
    {
        //public static Int32 PTTTK_KiemTraThongTinDauVao(string cmnd, int idhocphan, string ngaydkhocphan) { return 1; };
        //public static DataTable PTTK_LayThongTinDKHocPhan(string cmnd) { };
        //public static DataTable PTTK_HuyDKHocPhan(string cmnd, int idhocphan, string ngaydkhocphan) { };
        //public static DataTable PTTK_ThongTinChiTiet1DKHocPhan(string cmnd, int idhocphan, string ngaydkhocphan) {};
        //public static DataTable PTTK_ThongTinKhaiQuatDKHocPhan(string cmnd, int idhocphan, string ngaydkhocphan) {};
        //public static Int32 PTTK_KiemTraDiemHocPhan(int iddkhocphan) { return 1; };
        

        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static string THONGBAODAUROT { get; set; }
        public static Int32 PTTK_KiemTraDuocThiLai(string cmnd, int hocphan, string ngaydkhocphan)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            int isValid = 0;
            try
            {
                string query = @"SELECT [dbo].[PTTK_KiemTraDuocThiLai](@CMND,@IDHOCPHAN,@THOIGIANDK);";
                ///define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, con);
                //parameter value will be set from command line
                SqlParameter param0 = new SqlParameter();
                param0.ParameterName = "@CMND";
                param0.SqlDbType = SqlDbType.VarChar;
                param0.Value = cmnd;

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@IDHOCPHAN";
                param1.SqlDbType = SqlDbType.Int;
                param1.Value = hocphan;

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@THOIGIANDK";
                param2.SqlDbType = SqlDbType.Date;
                param2.Value = ngaydkhocphan;

                //pass parameter to the SQL Command
                cmd.Parameters.Add(param0);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
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

        public static DataTable PTTK_ThongTinChiTietDKHocPhan(string cmnd, int idhocphan, string ngaydkhocphan) {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_ThongTinChiTietDKHocPhan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CMNDHOCVIEN", SqlDbType.NVarChar).Value = cmnd;
                cmd.Parameters.Add("@IDHOCPHAN", SqlDbType.Int).Value = idhocphan;
                cmd.Parameters.Add("@THOIGIANDKHOCPHAN", SqlDbType.Date).Value = ngaydkhocphan;
                
                
                SqlParameter param_RETURNCODE;
                SqlParameter param_RETURNMESSAGE;
                SqlParameter param_THONGBAODAUROT;

                param_THONGBAODAUROT = cmd.Parameters.Add("@THONGBAODAUHAYKHONG", SqlDbType.NVarChar,500);
                param_THONGBAODAUROT.Direction = ParameterDirection.Output;

                param_RETURNCODE = cmd.Parameters.Add("@RETURNCODE", SqlDbType.Int);
                param_RETURNCODE.Direction = ParameterDirection.Output;
                param_RETURNMESSAGE = cmd.Parameters.Add("@RETURNMESS", SqlDbType.NVarChar, 500);
                param_RETURNMESSAGE.Direction = ParameterDirection.Output;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);

                //cmd.ExecuteNonQuery();

                ReturnCode = Convert.ToInt32(param_RETURNCODE.Value.ToString());
                ReturnMess = param_RETURNMESSAGE.Value.ToString();
                THONGBAODAUROT = param_THONGBAODAUROT.Value.ToString();
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

        public static DataTable PTTK_LayThongTinDKHocPhan(string cmnd) {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_LayThongTinDKHocPhan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CMNDHOCVIEN", SqlDbType.NVarChar).Value = cmnd;
               

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
        public static DataTable PTTK_HuyDKHocPhan(string cmnd, int idhocphan, string ngaydkhocphan)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_HuyDKHocPhan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CMNDHOCVIEN", SqlDbType.NVarChar).Value = cmnd;
                cmd.Parameters.Add("@IDHOCPHAN", SqlDbType.Int).Value = idhocphan;
                cmd.Parameters.Add("@THOIGIANDKHOCPHAN", SqlDbType.Date).Value = ngaydkhocphan;


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

        public static Int32 PTTK_KiemTraDiemHocPhan(int idhocvien, int idhocphan, string tgdk)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            int isValid = 0;
            try
            {
                string query = @"SELECT [dbo].[PTTK_KiemTraDiemHocPhan](@IDHOCVIEN,@IDHOCPHAN,@THOIGIANDKHOCPHAN);";
                ///define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, con);
                //parameter value will be set from command line
                SqlParameter param0 = new SqlParameter();
                param0.ParameterName = "@IDHOCVIEN";
                param0.SqlDbType = SqlDbType.Int;
                param0.Value = idhocvien;

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@IDHOCPHAN";
                param1.SqlDbType = SqlDbType.Int;
                param1.Value = idhocphan;

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@THOIGIANDKHOCPHAN";
                param2.SqlDbType = SqlDbType.Date;
                param2.Value = tgdk;

                //pass parameter to the SQL Command
                cmd.Parameters.Add(param0);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
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
