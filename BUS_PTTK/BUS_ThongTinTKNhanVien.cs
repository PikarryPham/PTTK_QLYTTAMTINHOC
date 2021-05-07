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
    public class BUS_ThongTinTKNhanVien
    {
        private string _TKNV_USERNAME;
        private string _TKNV_MATKHAU;
        private int _TKNV_LOAINHANVIEN;

        /*========== GETTER/SETTER ======*/
        public string TKNV_USERNAME
        {
            get
            {
                return _TKNV_USERNAME;
            }
            set
            {
                _TKNV_USERNAME = value;
            }
        }
        public string TKNV_MATKHAU
        {
            get
            {
                return _TKNV_MATKHAU;
            }
            set
            {
                _TKNV_MATKHAU = value;
            }
        }
        public int TKNV_LOAINHANVIEN
        {
            get
            {
                return _TKNV_LOAINHANVIEN;
            }
            set
            {
                _TKNV_LOAINHANVIEN = value;
            }
        }

        /* ==== Constructor =======*/
        public BUS_ThongTinTKNhanVien() { }
        public BUS_ThongTinTKNhanVien(string username, string psw, int typenv)
        {
            this.TKNV_USERNAME = username;
            this.TKNV_MATKHAU = psw;
            this.TKNV_LOAINHANVIEN = typenv;
        }
        /*============ Cac method =============*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
        public static void PTTK_KiemTraThongTinDauVao(BUS_ThongTinTKNhanVien bus_thongtinnv)
        {
            try
            {
                DAL_ThongTinTKNhanVien da = new DAL_ThongTinTKNhanVien(bus_thongtinnv.TKNV_USERNAME, bus_thongtinnv.TKNV_MATKHAU, bus_thongtinnv.TKNV_LOAINHANVIEN);
                DAL_ThongTinTKNhanVien.PTTK_KiemTraThongTinDauVao(da);
                ReturnCode = DAL_ThongTinTKNhanVien.ReturnCode;
                ReturnMess = DAL_ThongTinTKNhanVien.ReturnMess;
            }
            catch(Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
        }
    }
}
