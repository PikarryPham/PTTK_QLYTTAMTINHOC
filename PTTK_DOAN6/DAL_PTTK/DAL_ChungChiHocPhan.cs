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
    public class DAL_ChungChiHocPhan
    {
     
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
        public static string TenCC { get; set; }
        public static string NgayCapCC { get; set; }

        public static DataTable PTTK_LayThongTinChungChi(string cmndhocvien, int idhocphan, string ngaydkhocphan)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                //DateTime ngayDK = DateTime.ParseExact(ngaydkhocphan, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_LayThongTinChungChi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CMNDHOCVIEN", SqlDbType.VarChar).Value = cmndhocvien;
                cmd.Parameters.Add("@IDHOCPHAN", SqlDbType.Int).Value = idhocphan;
                cmd.Parameters.Add("@THOIGIANDKHOCPHAN", SqlDbType.Date).Value = ngaydkhocphan;

                SqlParameter param_RETURNCODE;
                SqlParameter param_RETURNMESSAGE;
                param_RETURNCODE = cmd.Parameters.Add("@RETURNCODE", SqlDbType.Int);
                param_RETURNCODE.Direction = ParameterDirection.Output;
                param_RETURNMESSAGE = cmd.Parameters.Add("@RETURNMESS", SqlDbType.NVarChar, 100);
                param_RETURNMESSAGE.Direction = ParameterDirection.Output;

                SqlParameter param_TENCC = cmd.Parameters.Add("@TENCC", SqlDbType.NVarChar, 100);
                param_TENCC.Direction = ParameterDirection.Output;

                SqlParameter param_NGAYCAPCC = cmd.Parameters.Add("@NGAYCAPCC", SqlDbType.NVarChar, 100);
                param_NGAYCAPCC.Direction = ParameterDirection.Output;



                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);


                cmd.ExecuteNonQuery();

                ReturnCode = Convert.ToInt32(param_RETURNCODE.Value.ToString());
                ReturnMess = param_RETURNMESSAGE.Value.ToString();

                TenCC = param_TENCC.Value.ToString();
                NgayCapCC = param_NGAYCAPCC.Value.ToString();

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
