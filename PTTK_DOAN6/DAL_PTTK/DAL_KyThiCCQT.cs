using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PTTK
{
    public class DAL_KyThiCCQT
    {
        private int _KTQT_ID;
        private string _KTQT_DIADIEM;
        private string _KTQT_TGBATDAU;
        private int _KTQT_TGLAMBAI;
        private int _KTQT_CCQT;

        /*========== GETTER/SETTER ======*/
        public int KTQT_ID
        {
            get
            {
                return _KTQT_ID;
            }
            set
            {
                _KTQT_ID = value;
            }
        }
        public string KTQT_DIADIEM
        {
            get
            {
                return _KTQT_DIADIEM;
            }
            set
            {
                _KTQT_DIADIEM = value;
            }
        }
        public int KTQT_TGLAMBAI
        {
            get
            {
                return _KTQT_TGLAMBAI;
            }
            set
            {
                _KTQT_TGLAMBAI = value;
            }
        }

        public string KTQT_TGBATDAU
        {
            get
            {
                return _KTQT_TGBATDAU;
            }
            set
            {
                _KTQT_TGBATDAU = value;
            }
        }

        public int KTQT_CCQT
        {
            get
            {
                return _KTQT_CCQT;
            }
            set
            {
                _KTQT_CCQT = value;
            }
        }

        /* ==== Constructor =======*/
        public DAL_KyThiCCQT() { }
        public DAL_KyThiCCQT(int idktqt, string diadiem, string thoigianbd, int thoigianlbai)
        {
            this.KTQT_ID = idktqt;
            this.KTQT_DIADIEM = diadiem;
            this.KTQT_TGBATDAU = thoigianbd;
            this.KTQT_TGLAMBAI = thoigianlbai;
        }
        public DAL_KyThiCCQT(string diadiem, string thoigianbd, int thoigianlbai)
        {
            this.KTQT_DIADIEM = diadiem;
            this.KTQT_TGBATDAU = thoigianbd;
            this.KTQT_TGLAMBAI = thoigianlbai;
        }

        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static DataTable PTTK_TaoMoiVaHienThiKyThiCCQT(DAL_KyThiCCQT kythiccqt, DAL_NgayThiKyThiCCQT ngaythiCCQT, DAL_CCQT ccqt )
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_TaoMoiVaHienThiKyThiCCQT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NGAYTHI", SqlDbType.Date).Value = ngaythiCCQT.NTKTQT_NGAY;
                cmd.Parameters.Add("@DIADIEMTHI", SqlDbType.NVarChar).Value = kythiccqt.KTQT_DIADIEM;
                cmd.Parameters.Add("@TENCCQT", SqlDbType.NVarChar).Value = ccqt.CCQT_TEN;
                cmd.Parameters.Add("@TGBD", SqlDbType.Time).Value = kythiccqt.KTQT_TGBATDAU;
                cmd.Parameters.Add("@TGLAMBAI", SqlDbType.Int).Value = kythiccqt.KTQT_TGLAMBAI;

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
        //public static DAL_KyThiCCQT PTTK_CapNhatVaHienThiThongTinMotKyThi(DAL_KyThiCCQT kythiccqt, DAL_NgayThiKyThiCCQT ngaythiCCQT, DAL_CCQT ccqt)
        //{
        //    DAL_KyThiCCQT capnhatkithiccqt = new DAL_KyThiCCQT();
        //    return capnhatkithiccqt;
        //}
        public static DataTable PTTK_CapNhatVaHienThiThongTinMotKyThi(DAL_KyThiCCQT kythiccqt, DAL_CCQT ccqt)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_CapNhatVaHienThiThongTinMotKyThi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKYTHICCQT", SqlDbType.Int).Value = kythiccqt.KTQT_ID;
                cmd.Parameters.Add("@TENCCQT", SqlDbType.NVarChar).Value = ccqt.CCQT_TEN;
                cmd.Parameters.Add("@DIADIEMTHI", SqlDbType.NVarChar).Value = kythiccqt.KTQT_DIADIEM;
                cmd.Parameters.Add("@TGBD", SqlDbType.Time).Value = kythiccqt.KTQT_TGBATDAU;
                cmd.Parameters.Add("@TGLAMBAI", SqlDbType.Int).Value = kythiccqt.KTQT_TGLAMBAI;

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
