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
    public class BUS_LichThiLai
    {
		private int _LTL_ID;
		private string _LTL_NGAY;
		private string _LTL_PHONG;
		private string _LTL_TGBATDAU;
		private int _LTL_TGLAMBAI;
		private int _LTL_DKHOCPHAN;

        /*========== GETTER/SETTER ======*/
        public int LTL_ID
        {
            get
            {
                return _LTL_ID;
            }
            set
            {
                _LTL_ID = value;
            }
        }
        public int LTL_TGLAMBAI
        {
            get
            {
                return _LTL_TGLAMBAI;
            }
            set
            {
                _LTL_TGLAMBAI = value;
            }
        }
        public int LTL_DKHOCPHAN
        {
            get
            {
                return _LTL_DKHOCPHAN;
            }
            set
            {
                _LTL_DKHOCPHAN = value;
            }
        }

        public string LTL_NGAY
        {
            get
            {
                return _LTL_NGAY;
            }
            set
            {
                _LTL_NGAY = value;
            }
        }

        public string LTL_PHONG
        {
            get
            {
                return _LTL_PHONG;
            }
            set
            {
                _LTL_PHONG = value;
            }
        }

        public string LTL_TGBATDAU
        {
            get
            {
                return _LTL_TGBATDAU;
            }
            set
            {
                _LTL_TGBATDAU = value;
            }
        }

        /* ==== Constructor =======*/
        public BUS_LichThiLai() { }
        public BUS_LichThiLai(int iddkhocphan, string ngaythi, string phong, string tgbd, int tglb)
        {
            this.LTL_DKHOCPHAN = iddkhocphan;
            this.LTL_NGAY = ngaythi;
            this.LTL_PHONG = phong;
            this.LTL_TGBATDAU = tgbd;
            this.LTL_TGLAMBAI = tglb;
        }
        

        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static DataTable PTTK_GhiNhanThongTinLichThiLai(BUS_LichThiLai x)
        {
            DataTable da = new DataTable();
            try
            {
                da = DAL_LichThiLai.PTTK_GhiNhanThongTinLichThiLai(x.LTL_DKHOCPHAN, x.LTL_NGAY, x.LTL_PHONG, x.LTL_TGBATDAU, x.LTL_TGLAMBAI);
                ReturnCode = DAL_LichThiLai.ReturnCode;
                ReturnMess = DAL_LichThiLai.ReturnMess;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        
    }
}
