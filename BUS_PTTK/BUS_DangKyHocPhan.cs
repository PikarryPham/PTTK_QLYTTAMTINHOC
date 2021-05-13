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
    public class BUS_DangKyHocPhan
    {
        private int _DKHP_ID;
        private float _DKHP_DIEMHP;
        private string _DKHP_NGAYDK;
        private int _DKHP_IDHOCVIEN;
        private int _DKHP_IDHP;
        private int _DKHP_IDHDHP;

        /*========== GETTER/SETTER ======*/
        public int DKHP_ID
        {
            get
            {
                return _DKHP_ID;
            }
            set
            {
                _DKHP_ID = value;
            }
        }
        public float DKHP_DIEMHP
        {
            get
            {
                return _DKHP_DIEMHP;
            }
            set
            {
                _DKHP_DIEMHP = value;
            }
        }
        public string DKHP_NGAYDK
        {
            get
            {
                return _DKHP_NGAYDK;
            }
            set
            {
                _DKHP_NGAYDK = value;
            }
        }

        public int DKHP_IDHOCVIEN
        {
            get
            {
                return _DKHP_IDHOCVIEN;
            }
            set
            {
                _DKHP_IDHOCVIEN = value;
            }
        }
        public int DKHP_IDHP
        {
            get
            {
                return _DKHP_IDHP;
            }
            set
            {
                _DKHP_IDHP = value;
            }
        }

        public int DKHP_IDHDHP
        {
            get
            {
                return _DKHP_IDHDHP;
            }
            set
            {
                _DKHP_IDHDHP = value;
            }
        }

        /* ==== Constructor =======*/
        public BUS_DangKyHocPhan() { }
        public BUS_DangKyHocPhan(int iddkhocphan, float diemhp, string ngaydk, int idhocvien, int idhp, int idhoadonhp)
        {
            this.DKHP_ID = iddkhocphan;
            this.DKHP_DIEMHP = diemhp;
            this.DKHP_NGAYDK = ngaydk;
            this.DKHP_IDHOCVIEN = idhocvien;
            this.DKHP_IDHP = idhp;
            this.DKHP_IDHDHP = idhoadonhp;
        }
        
        public BUS_DangKyHocPhan(int iddkhocphan)
        {
            this.DKHP_ID = iddkhocphan;
        }

        public BUS_DangKyHocPhan(string ngaydk)
        {
            this.DKHP_NGAYDK = ngaydk;
        }


        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static string TenHocPhan { get; set; }
        public static string TGBD { get; set; }
        public static string DiemHP { get; set; }
        public static string NgayDK { get; set; }
        public static string CMNDHV { get; set; }

        public static string THONGBAODAUROT { get; set; }
        public static Int32 PTTK_KiemTraDuocThiLai(BUS_HocVien x, BUS_HocPhan y, BUS_DangKyHocPhan z)
        {
            int isValid = 0;
            try
            {
                isValid = DAL_DangKyHocPhan.PTTK_KiemTraDuocThiLai(x.NDKT_CMND, y.HP_ID, z.DKHP_NGAYDK);
                ReturnCode = DAL_DangKyHocPhan.ReturnCode;
                ReturnMess = DAL_DangKyHocPhan.ReturnMess;
            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return isValid;
        }

        public static DataTable PTTK_ThongTinChiTietDKHocPhan(BUS_HocVien x, BUS_HocPhan y, BUS_DangKyHocPhan z)
        {
            DataTable da = new DataTable();
            try
            {
                da = DAL_DangKyHocPhan.PTTK_ThongTinChiTietDKHocPhan(x.NDKT_CMND, y.HP_ID, z.DKHP_NGAYDK);

                THONGBAODAUROT = DAL_DangKyHocPhan.THONGBAODAUROT;
                ReturnCode = DAL_DangKyHocPhan.ReturnCode;
                ReturnMess = DAL_DangKyHocPhan.ReturnMess;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static DataTable PTTK_LayThongTinDKHocPhan(BUS_HocVien x)
        {
            DataTable da = new DataTable();
            try
            {
                da = DAL_DangKyHocPhan.PTTK_LayThongTinDKHocPhan(x.NDKT_CMND);

                ReturnCode = DAL_DangKyHocPhan.ReturnCode;
                ReturnMess = DAL_DangKyHocPhan.ReturnMess;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static DataTable PTTK_HuyDKHocPhan(BUS_HocVien x, BUS_HocPhan y, BUS_DangKyHocPhan z)
        {
            DataTable da = new DataTable();
            try
            {
                da = DAL_DangKyHocPhan.PTTK_HuyDKHocPhan(x.NDKT_CMND, y.HP_ID, z.DKHP_NGAYDK);

                ReturnCode = DAL_DangKyHocPhan.ReturnCode;
                ReturnMess = DAL_DangKyHocPhan.ReturnMess;

            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }

        public static Int32 PTTK_KiemTraDiemHocPhan(BUS_HocVien x, BUS_HocPhan y, BUS_DangKyHocPhan z)
        {
            int isValid = 0;
            try
            {
                isValid = DAL_DangKyHocPhan.PTTK_KiemTraDiemHocPhan(x.NDKT_ID,y.HP_ID,z.DKHP_NGAYDK);
                ReturnCode = DAL_DangKyHocPhan.ReturnCode;
                ReturnMess = DAL_DangKyHocPhan.ReturnMess;
            }
            catch (Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return isValid;
        }

        public static DataTable PTTK_ThongTinKhaiQuatDKHocPhan(BUS_HocVien x, BUS_HocPhan y, BUS_DangKyHocPhan z)
        {
            try
            {
                var tbl = DAL_DangKyHocPhan.PTTK_ThongTinKhaiQuatDKHocPhan(x.NDKT_CMND, y.HP_ID, z.DKHP_NGAYDK);
                ReturnCode = DAL_DangKyHocPhan.ReturnCode;
                ReturnMess = DAL_DangKyHocPhan.ReturnMess;
                TenHocPhan = DAL_DangKyHocPhan.TenHocPhan;
                TGBD = DAL_DangKyHocPhan.TGBD;
                DiemHP = DAL_DangKyHocPhan.DiemHP;
                NgayDK = DAL_DangKyHocPhan.NgayDK;
                CMNDHV = DAL_DangKyHocPhan.CMNDHV;
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
