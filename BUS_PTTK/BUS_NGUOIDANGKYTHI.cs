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
    public class BUS_NGUOIDANGKYTHI
    {
        private int _NDKT_ID;
        private string _NDKT_CMND;
        private string _NDKT_TEN;
        private string _NDKT_DCHI;
        private string _NDKT_EMAIL;
        private string _NDKT_GTINH;
        private string _NDKT_LOAI;
        private string _NDKT_SDT;

        /*========== GETTER/SETTER ======*/
        public int NDKT_ID
        {
            get
            {
                return _NDKT_ID;
            }
            set
            {
                _NDKT_ID = value;
            }
        }
        public string NDKT_CMND
        {
            get
            {
                return _NDKT_CMND;
            }
            set
            {
                _NDKT_CMND = value;
            }
        }
        public string NDKT_TEN
        {
            get
            {
                return _NDKT_TEN;
            }
            set
            {
                _NDKT_TEN = value;
            }
        }
        public string NDKT_DCHI
        {
            get
            {
                return _NDKT_DCHI;
            }
            set
            {
                _NDKT_DCHI = value;
            }
        }
        public string NDKT_EMAIL
        {
            get
            {
                return _NDKT_EMAIL;
            }
            set
            {
                _NDKT_EMAIL = value;
            }
        }
        public string NDKT_GTINH
        {
            get
            {
                return _NDKT_GTINH;
            }
            set
            {
                _NDKT_GTINH = value;
            }
        }
        public string NDKT_LOAI
        {
            get
            {
                return _NDKT_LOAI;
            }
            set
            {
                _NDKT_LOAI = value;
            }
        }
        public string NDKT_SDT
        {
            get
            {
                return _NDKT_SDT;
            }
            set
            {
                _NDKT_SDT = value;
            }
        }
        /* ==== Constructor =======*/
        public BUS_NGUOIDANGKYTHI() { }
        
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
        
    }
}
