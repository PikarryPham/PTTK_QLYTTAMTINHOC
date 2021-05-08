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
    public class DAL_CCQT
    {
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
        public static Int32 PTTK_KiemTraTonTaiTenCCQT(string tenccqt)
        {
            SqlConnection con = DataConnection.GetSqlConnection();
            DataTable tbl = new DataTable();
            int isValid = 0;
            return isValid;
        }
    }
}
