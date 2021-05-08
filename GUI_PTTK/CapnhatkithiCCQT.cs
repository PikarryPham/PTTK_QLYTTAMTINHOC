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
    public partial class CapnhatkithiCCQT : Form
    {
        public CapnhatkithiCCQT()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void btnhienthidscapnhat_Click(object sender, EventArgs e)
        {
            capnhatkythi_listdskythi.DataSource = BUS_KyThiCCQT.PTTK_LayDanhSachKyThiCCQT();
        }

        private void backcapnhat_Click(object sender, EventArgs e)
        {
            Form form = new TrangCaNhan_QuanLy();
            form.Show();
            this.Close();
        }

        private void capnhatbtn_Click(object sender, EventArgs e)
        {
            // Tao moi cac object
            BUS_KyThiCCQT kithiccqt = new BUS_KyThiCCQT(Int32.Parse(capnhat_makythiccqt.Text),capnhat_diadiemthi.Text, capnhat_thoigianbdccqt.Text, Convert.ToInt32(capnhat_thoigianlambai.Value));
            BUS_CCQT ccqte = new BUS_CCQT(capnhat_tenkithi.Text);
            MessageBox.Show(capnhat_tenkithi.Text);
            dataGridView1.DataSource = BUS_KyThiCCQT.PTTK_CapNhatVaHienThiThongTinMotKyThi(kithiccqt, ccqte);
            MessageBox.Show(BUS_KyThiCCQT.ReturnMess);
        }
    }
}
