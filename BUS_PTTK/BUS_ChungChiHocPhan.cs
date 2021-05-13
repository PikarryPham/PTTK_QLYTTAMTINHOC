using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PTTK;

namespace BUS_PTTK
{
    public class BUS_ChungChiHocPhan
    {
        private static int _CC_ID;
        private static string _CC_NGAYCAP;
        private static string _CC_TEN;
        private static int _CC_DKHOCPHAN;

        /*========== GETTER/SETTER ======*/
        public int CC_ID
        {
            get
            {
                return _CC_ID;
            }
            set
            {
                _CC_ID = value;
            }
        }
        public int CC_DKHOCPHAN
        {
            get
            {
                return _CC_DKHOCPHAN;
            }
            set
            {
                _CC_DKHOCPHAN = value;
            }
        }

        public string CC_NGAYCAP
        {
            get
            {
                return _CC_NGAYCAP;
            }
            set
            {
                _CC_NGAYCAP = value;
            }
        }

        public string CC_TEN
        {
            get
            {
                return _CC_TEN;
            }
            set
            {
                _CC_TEN = value;
            }
        }

        /* ==== Constructor =======*/
        public BUS_ChungChiHocPhan() { }

        /* ======= Method ========= */
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
        public static string TenCC { get; set; }
        public static string NgayCapCC { get; set; }

        public static DataTable PTTK_LayThongTinChungChi(BUS_HocVien x, BUS_HocPhan y, BUS_DangKyHocPhan z)
        {
            try
            {
                var tbl = DAL_ChungChiHocPhan.PTTK_LayThongTinChungChi(x.NDKT_CMND,y.HP_ID,z.DKHP_NGAYDK);
                ReturnCode = DAL_ChungChiHocPhan.ReturnCode;
                ReturnMess = DAL_ChungChiHocPhan.ReturnMess;
                TenCC = DAL_ChungChiHocPhan.TenCC;
                NgayCapCC = DAL_ChungChiHocPhan.NgayCapCC;

                return tbl;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
                return new DataTable();
            }
        }

    }
}
