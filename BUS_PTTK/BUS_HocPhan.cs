using System;
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
    public class BUS_HocPhan
    {
        private int _HP_ID;
        private string _HP_MAHOCPHAN;
        private string _HP_THOIGIANBD;
        private string _HP_LOAIHP;
        private int _HP_OPENCHECK;
        private int _HP_SISO;
        private int _HP_SOCHI;
        private string _HP_TEN;
        private string _HP_THOIGIANKT;

        /*========== GETTER/SETTER ======*/
        public int HP_ID
        {
            get
            {
                return _HP_ID;
            }
            set
            {
                _HP_ID = value;
            }
        }

        /* ==== Constructor =======*/
        public BUS_HocPhan() { }
        public BUS_HocPhan(int idhocphan) { this.HP_ID = idhocphan; }


    }
}
