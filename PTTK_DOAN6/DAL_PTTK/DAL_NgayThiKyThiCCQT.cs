﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PTTK
{
    public class DAL_NgayThiKyThiCCQT
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
        public DAL_NgayThiKyThiCCQT() { }
        public DAL_NgayThiKyThiCCQT(int idktqt, string ngaythi)
        {
            this.KTQT_ID = idktqt;
            this.NTKTQT_NGAY = ngaythi;
        }
        public DAL_NgayThiKyThiCCQT(string ngaythi)
        {
            this.NTKTQT_NGAY = ngaythi;
        }
        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
    }
}
