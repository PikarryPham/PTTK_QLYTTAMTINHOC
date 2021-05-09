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
    public class BUS_NgayThiKyThiCCQT
    {
        private int _KTQT_ID;
        private string _NTKTQT_NGAY;

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
        public string NTKTQT_NGAY
        {
            get
            {
                return _NTKTQT_NGAY;
            }
            set
            {
                _NTKTQT_NGAY = value;
            }
        }
        /* ==== Constructor =======*/
        public BUS_NgayThiKyThiCCQT() { }
        public BUS_NgayThiKyThiCCQT(int idktqt, string ngaythi)
        {
            this.KTQT_ID = idktqt;
            this.NTKTQT_NGAY = ngaythi;
        }
        public BUS_NgayThiKyThiCCQT(string ngaythi)
        {
            this.NTKTQT_NGAY = ngaythi;
        }
        public BUS_NgayThiKyThiCCQT(int kythiccqt)
        {
            this.KTQT_ID = kythiccqt;
        }
        
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static DataTable PTTK_LayDanhSachCacNgayThiCCQT(BUS_NgayThiKyThiCCQT ngaythiccqt)
        {
            DataTable da = new DataTable();
            try
            {

                da = DAL_NgayThiKyThiCCQT.PTTK_LayDanhSachCacNgayThiCCQT(ngaythiccqt._KTQT_ID);

                ReturnCode = DAL_KyThiCCQT.ReturnCode;
                ReturnMess = DAL_KyThiCCQT.ReturnMess;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static DataTable PTTK_ThemNgayThiMoi(BUS_NgayThiKyThiCCQT ngaythiccqt)
        {
            DataTable da = new DataTable();
            try
            {

                da = DAL_NgayThiKyThiCCQT.PTTK_ThemNgayThiMoi(ngaythiccqt.KTQT_ID, ngaythiccqt.NTKTQT_NGAY);

                ReturnCode = DAL_NgayThiKyThiCCQT.returnCode1;
                ReturnMess = DAL_NgayThiKyThiCCQT.returnMess1;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static DataTable PTTK_XoaNgayThiHienTai(BUS_NgayThiKyThiCCQT ngaythiccqt)
        {
            DataTable da = new DataTable();
            try
            {
                da = DAL_NgayThiKyThiCCQT.PTTK_XoaNgayThiHienTai(ngaythiccqt.KTQT_ID, ngaythiccqt.NTKTQT_NGAY);

                ReturnCode = DAL_NgayThiKyThiCCQT.returnCode1;
                ReturnMess = DAL_NgayThiKyThiCCQT.returnMess1;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static DataTable PTTK_CapNhatNgayThi(BUS_NgayThiKyThiCCQT ngaythiccqtcu, BUS_NgayThiKyThiCCQT ngaythiccqtmoi)
        {
            DataTable da = new DataTable();
            try
            {
                da = DAL_NgayThiKyThiCCQT.PTTK_CapNhatNgayThi(ngaythiccqtcu.KTQT_ID, ngaythiccqtcu.NTKTQT_NGAY, ngaythiccqtmoi.NTKTQT_NGAY);
                ReturnCode = DAL_NgayThiKyThiCCQT.returnCode1;
                ReturnMess = DAL_NgayThiKyThiCCQT.returnMess1;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static Int32 PTTK_KiemTraMaKiThiCCQT(BUS_NgayThiKyThiCCQT ngaythiccqt)
        {
            int isValid = 0;
            try
            {
                isValid = DAL_NgayThiKyThiCCQT.PTTK_KiemTraMaKiThiCCQT(ngaythiccqt.KTQT_ID);
                ReturnCode = DAL_NgayThiKyThiCCQT.returnCode1;
                ReturnMess = DAL_NgayThiKyThiCCQT.returnMess1;
            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return isValid;
        }
    }
}
