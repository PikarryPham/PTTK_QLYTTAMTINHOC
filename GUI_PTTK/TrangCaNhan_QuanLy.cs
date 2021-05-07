using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PTTK
{
    public partial class TrangCaNhan_QuanLy : Form
    {
        public TrangCaNhan_QuanLy()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }
        private void backcapnhat_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Show();
            this.Close();
        }

        private void trangcn_taokithi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newform = new ThemkithiCCQT();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
        }

        private void trangcn_capnhatkithi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newform = new CapnhatkithiCCQT();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
        }

        private void trangcn_quanlyngaythiCCQT_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newform = new Chon_ngay_thi_cho_ky_thi_CCQT();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
        }
    }
}
