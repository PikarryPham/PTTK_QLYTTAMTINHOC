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
    public class BUS_HocVien
    {
		// Lam tuong tu nhu cac BUS khac, ban tham khao script tao bang de biet duoc gom cac thuoc tinh gi
		// Trong script tao bang, HocVien chinh la Nguoi Dang Ky Thi
		private int NDKT_ID_;
		private string NDKT_CMND_;
		private string NDKT_TEN_;
		private string NDKT_DCHI_;
		private string NDKT_EMAIL_;
		private string NDKT_GTINH_;
		private string NDKT_LOAI_;
		private string NDKT_SDT_;

        /*========== GETTER/SETTER ======*/
        public int NDKT_ID
        {
            get
            {
                return NDKT_ID_;
            }
            set
            {
                NDKT_ID_ = value;
            }
        }
        public string NDKT_CMND
        {
            get
            {
                return NDKT_CMND_;
            }
            set
            {
                NDKT_CMND_ = value;
            }
        }

        /* ==== Constructor =======*/
        public BUS_HocVien() { }

        public BUS_HocVien(int idhocvien, string cmnd)
        {
            this.NDKT_CMND = cmnd;
            this.NDKT_ID = idhocvien;
        }
        public BUS_HocVien(string cmnd)
        {
            this.NDKT_CMND = cmnd;
        }
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static DataTable PTTK_LayDSHocVien()
        {
            DataTable da = new DataTable();
            try
            {
                da = DAL_HocVien.PTTK_LayDSHocVien();
                ReturnCode = DAL_HocVien.ReturnCode;
                ReturnMess = DAL_HocVien.ReturnMess;
            }
            catch(Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }
    }
}
