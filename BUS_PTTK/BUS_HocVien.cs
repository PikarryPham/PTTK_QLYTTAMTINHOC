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
    public class BUS_HocVien : BUS_NGUOIDANGKYTHI
    {
        private int v;

        /* ==== Constructor =======*/
        public BUS_HocVien() { }
        public BUS_HocVien(string tenhv, string cmnd, string gtinh, string dchi, string email, string sdt)
        {
            this.NDKT_TEN = tenhv;
            this.NDKT_CMND = cmnd;
            this.NDKT_GTINH = gtinh;
            this.NDKT_DCHI = dchi;
            this.NDKT_EMAIL = email;
            this.NDKT_SDT = sdt;
        }

        public BUS_HocVien(int v)
        {
            this.v = v;
        }

        public static DataTable LayDanhSachHocVien()
        {
            DataTable da = new DataTable();
            try
            {

                da = DAL_HocVien.LayDanhSachHocVien();

                ReturnCode = DAL_HocVien.ReturnCode;
                ReturnMess = DAL_HocVien.ReturnMess;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static DataTable ThemHocVienMoi(BUS_HocVien hocvien)
        {
            DataTable da = new DataTable();
            try
            {

                da = DAL_HocVien.ThemHocVienMoi(hocvien.NDKT_CMND, hocvien.NDKT_TEN, hocvien.NDKT_DCHI, hocvien.NDKT_EMAIL, hocvien.NDKT_GTINH, hocvien.NDKT_SDT);

                ReturnCode = DAL_HocVien.ReturnCode;
                ReturnMess = DAL_HocVien.ReturnMess;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static DataTable SuaThongTinHocVien(BUS_HocVien hocvien)
        {
            DataTable da = new DataTable();
            try
            {

                da = DAL_HocVien.SuaThongTinHocVien(hocvien.NDKT_ID, hocvien.NDKT_CMND, hocvien.NDKT_TEN, hocvien.NDKT_DCHI, hocvien.NDKT_EMAIL, hocvien.NDKT_GTINH, hocvien.NDKT_SDT);

                ReturnCode = DAL_HocVien.ReturnCode;
                ReturnMess = DAL_HocVien.ReturnMess;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }
        public static void KiemTraTonTaiMaHV(BUS_HocVien hocvien)
        {
            try
            {
                DAL_HocVien.KiemTraTonTaiMaHV(hocvien.NDKT_ID);
                ReturnCode = DAL_HocVien.ReturnCode;
                ReturnMess = DAL_HocVien.ReturnMess;
            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
        }
    }
}
