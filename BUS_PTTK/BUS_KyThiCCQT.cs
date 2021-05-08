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
    public class BUS_KyThiCCQT
    {
        private int _KTQT_ID;
        private string _KTQT_DIADIEM;
        private string _KTQT_TGBATDAU;
        private int _KTQT_TGLAMBAI;
        private int _KTQT_CCQT;

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
        public string KTQT_DIADIEM
        {
            get
            {
                return _KTQT_DIADIEM;
            }
            set
            {
                _KTQT_DIADIEM = value;
            }
        }
        public int KTQT_TGLAMBAI
        {
            get
            {
                return _KTQT_TGLAMBAI;
            }
            set
            {
                _KTQT_TGLAMBAI = value;
            }
        }

        public string KTQT_TGBATDAU
        {
            get
            {
                return _KTQT_TGBATDAU;
            }
            set
            {
                _KTQT_TGBATDAU = value;
            }
        }

        public int KTQT_CCQT
        {
            get
            {
                return _KTQT_CCQT;
            }
            set
            {
                _KTQT_CCQT = value;
            }
        }

        /* ==== Constructor =======*/
        public BUS_KyThiCCQT() { }
        public BUS_KyThiCCQT(int idktqt, string diadiem, string thoigianbd, int thoigianlbai)
        {
            this.KTQT_ID = idktqt;
            this.KTQT_DIADIEM = diadiem;
            this.KTQT_TGBATDAU = thoigianbd;
            this.KTQT_TGLAMBAI = thoigianlbai;
        }
        public BUS_KyThiCCQT(string diadiem, string thoigianbd, int thoigianlbai)
        {
            this.KTQT_DIADIEM = diadiem;
            this.KTQT_TGBATDAU = thoigianbd;
            this.KTQT_TGLAMBAI = thoigianlbai;
        }

        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static DataTable PTTK_TaoMoiVaHienThiKyThiCCQT(BUS_KyThiCCQT kythiccqte, BUS_NgayThiKyThiCCQT ngaythiCCQTe, BUS_CCQT ccqte)
        {
            DataTable da = new DataTable();
            try
            {
                DAL_KyThiCCQT dal_kithiccqt = new DAL_KyThiCCQT(kythiccqte.KTQT_DIADIEM, kythiccqte.KTQT_TGBATDAU, kythiccqte.KTQT_TGLAMBAI);
                DAL_CCQT dal_ccqt = new DAL_CCQT(ccqte.CCQT_TEN);
                DAL_NgayThiKyThiCCQT dal_ngaythiccqte = new DAL_NgayThiKyThiCCQT(ngaythiCCQTe.NTKTQT_NGAY);
                da = DAL_KyThiCCQT.PTTK_TaoMoiVaHienThiKyThiCCQT(dal_kithiccqt,dal_ngaythiccqte,dal_ccqt);

                ReturnCode = DAL_KyThiCCQT.ReturnCode;
                ReturnMess = DAL_KyThiCCQT.ReturnMess;

            } catch(Exception ex)
            {
                ReturnCode = 500;
                ReturnMess = ex.Message;
            }
            return da;
        }
        public static DataTable PTTK_LayDanhSachKyThiCCQT()
        {
            DataTable da = new DataTable();
            try
            {
                da = DAL_KyThiCCQT.PTTK_LayDanhSachKyThiCCQT();

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
        public static DataTable PTTK_CapNhatVaHienThiThongTinMotKyThi(BUS_KyThiCCQT kythiccqte, BUS_CCQT ccqt)
        {
            DataTable da = new DataTable();
            try
            {
                DAL_KyThiCCQT dal_kithiccqt = new DAL_KyThiCCQT(kythiccqte.KTQT_ID,kythiccqte.KTQT_DIADIEM, kythiccqte.KTQT_TGBATDAU, kythiccqte.KTQT_TGLAMBAI);
                DAL_CCQT dal_ccqt = new DAL_CCQT(ccqt.CCQT_TEN);
                da = DAL_KyThiCCQT.PTTK_CapNhatVaHienThiThongTinMotKyThi(dal_kithiccqt, dal_ccqt);

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
    }
}
