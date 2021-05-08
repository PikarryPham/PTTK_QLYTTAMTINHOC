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
    public partial class ThemkithiCCQT : Form
    {
        public ThemkithiCCQT()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void taomoibtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(diadiemthi.Text) || string.IsNullOrEmpty(tenkithiccqt.Text) || string.IsNullOrEmpty(ngaythiccqt.Text) ||
                string.IsNullOrEmpty(thoigianbdccqt.Text) || string.IsNullOrEmpty(thoigianlambai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            // Tao moi cac object
            BUS_NgayThiKyThiCCQT ngaythimotccqt = new BUS_NgayThiKyThiCCQT((ngaythiccqt.Value.ToString()));
            BUS_KyThiCCQT kithiccqt = new BUS_KyThiCCQT(diadiemthi.Text, thoigianbdccqt.Text, Int32.Parse(thoigianlambai.Text));
            BUS_CCQT ccqte = new BUS_CCQT(tenkithiccqt.Text);
            datagridview_kithiCCQTsaukhitao.DataSource = BUS_KyThiCCQT.PTTK_TaoMoiVaHienThiKyThiCCQT(kithiccqt, ngaythimotccqt, ccqte);
            MessageBox.Show(BUS_KyThiCCQT.ReturnMess);
        }

        private void backTrangTaomoi_Click(object sender, EventArgs e)
        {
            Form form = new TrangCaNhan_QuanLy();
            form.Show();
            this.Close();
        }
    }
}
