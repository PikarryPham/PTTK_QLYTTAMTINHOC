using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BUS_PTTK
{
    public class BUS_ThemPCGD
    {
        private int _PCGD_IDHP;
        private int _PCGD_IDGV;
        /*========== GETTER/SETTER ======*/
        public int PCGD_IDHP
        {
            get
            {
                return _PCGD_IDHP;
            }
            set
            {
                _PCGD_IDHP = value;
            }
        }
        public int PCGD_IDGV
        {
            get
            {
                return _PCGD_IDGV;
            }
            set
            {
                _PCGD_IDGV = value;
            }
        }
        /* ==== Constructor =======*/
        public BUS_ThemPCGD() { }
        public BUS_ThemPCGD(int idhp, int idgv)
        {
            this._PCGD_IDHP = idhp;
            this._PCGD_IDGV = idgv;
        }
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
    }
}
