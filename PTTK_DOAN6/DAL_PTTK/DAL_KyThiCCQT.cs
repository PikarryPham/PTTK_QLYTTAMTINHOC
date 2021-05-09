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
    public class DAL_KyThiCCQT
    {
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
        public static DataTable PTTK_LayDanhSachKyThiCCQT()
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_LayDanhSachKyThiCCQT", con);
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
        
        public static DataTable PTTK_TaoMoiVaHienThiKyThiCCQT(string ngaythi, string diadiemthi, string tenccqt, string tgbd, int tglb)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_TaoMoiVaHienThiKyThiCCQT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NGAYTHI", SqlDbType.Date).Value = ngaythi;
                cmd.Parameters.Add("@DIADIEMTHI", SqlDbType.NVarChar).Value = diadiemthi;
                cmd.Parameters.Add("@TENCCQT", SqlDbType.NVarChar).Value = tenccqt;
                //MessageBox.Show(tenccqt);
                cmd.Parameters.Add("@TGBD", SqlDbType.Time).Value = tgbd;
                cmd.Parameters.Add("@TGLAMBAI", SqlDbType.Int).Value = tglb;

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
        public static DataTable PTTK_CapNhatVaHienThiThongTinMotKyThi(int makithiccqt, string diadiemthi, string tenccqt, string tgbd, int tglb)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_CapNhatVaHienThiThongTinMotKyThi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKYTHICCQT", SqlDbType.Int).Value = makithiccqt;

                // Xet TH Ten Nha co duoc dien vao hay khong, neu khong thi se ntn?
                if (!string.IsNullOrWhiteSpace(tenccqt))
                    cmd.Parameters.Add("@TENCCQT", SqlDbType.NVarChar).Value = tenccqt;
                else
                    cmd.Parameters.Add("@TENCCQT", SqlDbType.NVarChar).Value = DBNull.Value;

                // Xet TH Dia Diem Thi co duoc dien vao hay khong, neu khong thi se ntn?
                if (!string.IsNullOrWhiteSpace(diadiemthi))
                    cmd.Parameters.Add("@DIADIEMTHI", SqlDbType.NVarChar).Value = diadiemthi;
                else
                    cmd.Parameters.Add("@DIADIEMTHI", SqlDbType.NVarChar).Value = DBNull.Value;

                // Xet TH Thoi gian bat dau co duoc dien vao hay khong, neu khong thi se ntn?
                if (!string.IsNullOrWhiteSpace(tgbd))
                    cmd.Parameters.Add("@TGBD", SqlDbType.Time).Value = tgbd;
                else
                    cmd.Parameters.Add("@TGBD", SqlDbType.Time).Value = DBNull.Value;

                // Xet TH Thoi gian bat dau co duoc dien vao hay khong, neu khong thi se ntn?
                if (tglb != null || tglb != 0 )
                    cmd.Parameters.Add("@TGLAMBAI", SqlDbType.Int).Value = tglb;
                else
                    cmd.Parameters.Add("@TGLAMBAI", SqlDbType.Int).Value = DBNull.Value;
                

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
