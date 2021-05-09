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
    public class BUS_CCQT
    {
        private int _CCQT_ID;
        private double _CCQT_PHICAP;
        private double _CCQT_PHIDK;
        private string _CCQT_TEN;

        /*========== GETTER/SETTER ======*/
        public int CCQT_ID
        {
            get
            {
                return _CCQT_ID;
            }
            set
            {
                _CCQT_ID = value;
            }
        }
        public double CCQT_PHICAP
        {
            get
            {
                return _CCQT_PHICAP;
            }
            set
            {
                _CCQT_PHICAP = value;
            }
        }
        public double CCQT_PHIDK
        {
            get
            {
                return _CCQT_PHIDK;
            }
            set
            {
                _CCQT_PHIDK = value;
            }
        }

        public string CCQT_TEN
        {
            get
            {
                return _CCQT_TEN;
            }
            set
            {
                _CCQT_TEN = value;
            }
        }
        /* ==== Constructor =======*/
        public BUS_CCQT() { }
        public BUS_CCQT(int idccqt, double phicapccqt, double phidkccqp, string tenccqt)
        {
            this.CCQT_ID = idccqt;
            this.CCQT_PHICAP = phicapccqt;
            this.CCQT_PHIDK = phidkccqp;
            this.CCQT_TEN = tenccqt;
        }
        public BUS_CCQT(string tenccqt)
        {
            this.CCQT_TEN = tenccqt;
        }
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }

        public static Int32 PTTK_KiemTraTonTaiTenCCQT(BUS_CCQT ccqt)
        {
            int isValid = 0;
            try
            {
                isValid = DAL_CCQT.PTTK_KiemTraTonTaiTenCCQT(ccqt.CCQT_TEN);
                ReturnCode = DAL_CCQT.ReturnCode;
                ReturnMess = DAL_CCQT.ReturnMess;
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
