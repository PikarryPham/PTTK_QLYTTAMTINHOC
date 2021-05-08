﻿using System;
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

        /* ========= Method ===========*/
        public static int ReturnCode { get; set; }
        public static string ReturnMess { get; set; }
    }
}
