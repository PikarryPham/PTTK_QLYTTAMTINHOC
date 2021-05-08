using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_PTTK;

namespace GUI_PTTK
{
    public partial class Chon_ngay_thi_cho_ky_thi_CCQT : Form
    {
        public Chon_ngay_thi_cho_ky_thi_CCQT()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void backTrangTaomoi_Click(object sender, EventArgs e)
        {
            Form form = new TrangCaNhan_QuanLy();
            form.Show();
            this.Close();
        }

        private void showlistkithiccqt_chinhsuangaythi_Click(object sender, EventArgs e)
        {
            //if (BUS_KyThiCCQT.ReturnCode != 1)
            //{
            //    capnhatkythi_listdskythi.DataSource = BUS_KyThiCCQT.PTTK_LayDanhSachKyThiCCQT();
            //}
        }
    }
}
