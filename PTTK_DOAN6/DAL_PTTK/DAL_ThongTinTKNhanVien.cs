using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PTTK
{
    public class DAL_ThongTinTKNhanVien
    {
        private string _TKNV_USERNAME;
        private string _TKNV_MATKHAU;
        private int _TKNV_LOAINHANVIEN;

        /*========== GETTER/SETTER ======*/
        public string TKNV_USERNAME
        {
            get
            {
                return _TKNV_USERNAME;
            }
            set
            {
                _TKNV_USERNAME = value;
            }
        }
        public string TKNV_MATKHAU
        {
            get
            {
                return _TKNV_MATKHAU;
            }
            set
            {
                _TKNV_MATKHAU = value;
            }
        }
        public int TKNV_LOAINHANVIEN
        {
            get
            {
                return _TKNV_LOAINHANVIEN;
            }
            set
            {
                _TKNV_LOAINHANVIEN = value;
            }
        }

        /* ==== Constructor =======*/
        public DAL_ThongTinTKNhanVien() { }
        public DAL_ThongTinTKNhanVien(string username, string psw, int typenv)
        {
            this.TKNV_USERNAME = username;
            this.TKNV_MATKHAU = psw;
            this.TKNV_LOAINHANVIEN = typenv;
        }
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
        public static DataTable PTTK_KiemTraThongTinDauVao(DAL_ThongTinTKNhanVien dal_thongtinnv)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_KiemTraThongTinDauVao", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = dal_thongtinnv.TKNV_USERNAME;
                cmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = dal_thongtinnv.TKNV_MATKHAU;
                cmd.Parameters.Add("@LOAINHANVIEN", SqlDbType.Int).Value = dal_thongtinnv.TKNV_LOAINHANVIEN;

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
            return tbl;
        }
    }
}
