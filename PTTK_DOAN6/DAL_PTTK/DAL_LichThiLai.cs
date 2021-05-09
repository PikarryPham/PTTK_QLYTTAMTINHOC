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
    public class DAL_LichThiLai
    {
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
        

        public static DataTable PTTK_GhiNhanThongTinLichThiLai(int iddkhocphan, string ngaythilai, string phongthi, string thoigianbd, int thoigianlb)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PTTK_GhiNhanThongTinLichThiLai", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDDKHOCPHAN", SqlDbType.Int).Value = iddkhocphan;
                cmd.Parameters.Add("@NGAYTHILAI", SqlDbType.Date).Value = ngaythilai;
                cmd.Parameters.Add("@PHONGTHI", SqlDbType.NVarChar).Value = phongthi;
                cmd.Parameters.Add("@THOIGIANBD", SqlDbType.Time).Value = thoigianbd;
                cmd.Parameters.Add("@THGIANLAMBAI", SqlDbType.Int).Value = thoigianlb;

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
