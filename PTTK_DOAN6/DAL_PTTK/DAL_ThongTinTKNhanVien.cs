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
        public static DataSet PTTK_KiemTraThongTinDauVao(DAL_ThongTinTKNhanVien thongtinnv)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataSet dataSet = new DataSet();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("PTTK_KiemTraThongTinDauVao", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@USERNAME", thongtinnv.TKNV_USERNAME));
                command.Parameters.Add(new SqlParameter("@PASS", thongtinnv.TKNV_MATKHAU));
                command.Parameters.Add("@LOAINHANVIENN", SqlDbType.Int).Value = thongtinnv.TKNV_LOAINHANVIEN;

                SqlParameter param_RETURNCODE;
                SqlParameter param_RETURNMESSAGE;
                param_RETURNCODE = command.Parameters.Add("@RETURNCODE", SqlDbType.Int);
                param_RETURNCODE.Direction = ParameterDirection.Output;
                param_RETURNMESSAGE = command.Parameters.Add("@RETURNMESS", SqlDbType.NVarChar, 500);
                param_RETURNMESSAGE.Direction = ParameterDirection.Output;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dataSet);

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
            return dataSet;
        }
    }
}
