using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL_PTTK
{
    public class DAL_HocVien
    {
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static DataTable LayDanhSachHocVien()
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LayDanhSachHocVien", con);
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

        public static DataTable ThemHocVienMoi(string cmnd, string tenhv, string diachi, string email, string gtinh, string sdt)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ThemHocVienMoi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd;
                cmd.Parameters.Add("@TENHV", SqlDbType.NVarChar).Value = tenhv;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@GTINH", SqlDbType.NVarChar).Value = gtinh;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;

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

        public static DataTable SuaThongTinHocVien(int idhv, string cmnd, string tenhv, string diachi, string email, string gtinh, string sdt)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SuaThongTinHocVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_HV", SqlDbType.Int).Value = idhv;
                cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd;
                cmd.Parameters.Add("@TENHV", SqlDbType.NVarChar).Value = tenhv;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@GTINH", SqlDbType.NVarChar).Value = gtinh;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;

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

        public static DataTable KiemTraTonTaiMaHV(int idhv)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("KiemTraTonTaiMaHV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDHV", SqlDbType.Int).Value = idhv;

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
    }
}
