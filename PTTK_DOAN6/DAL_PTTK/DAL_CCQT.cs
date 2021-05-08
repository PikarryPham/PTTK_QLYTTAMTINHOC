using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PTTK
{
    public class DAL_CCQT
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
        public DAL_CCQT() { }
        public DAL_CCQT(int idccqt, double phicapccqt, double phidkccqp, string tenccqt)
        {
            this.CCQT_ID = idccqt;
            this.CCQT_PHICAP = phicapccqt;
            this.CCQT_PHIDK = phidkccqp;
            this.CCQT_TEN = tenccqt;
        }
        public DAL_CCQT(string tenccqt)
        {
            this.CCQT_TEN = tenccqt;
        }
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
    }
}
