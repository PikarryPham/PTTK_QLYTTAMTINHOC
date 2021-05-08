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
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void showlistkithiccqt_chinhsuangaythi_Click(object sender, EventArgs e)
        {
            chinhsuangaythi_dskithiCCQT.DataSource = BUS_KyThiCCQT.PTTK_LayDanhSachKyThiCCQT();
        }

        private void timdscacngaythi_chinhsuangaythikithiccqt_Click(object sender, EventArgs e)
        {
            BUS_NgayThiKyThiCCQT ngaythichungchiqt = new BUS_NgayThiKyThiCCQT(Convert.ToInt32(makithiccqt_quanli.Value));
            dataGridView1.DataSource = BUS_NgayThiKyThiCCQT.PTTK_LayDanhSachCacNgayThiCCQT(ngaythichungchiqt);
        }

        private void themngaythi_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
