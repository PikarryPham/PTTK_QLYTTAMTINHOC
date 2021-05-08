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
    public partial class Tracuuketquahp01 : Form
    {
        public Tracuuketquahp01()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void backTrang_Click(object sender, EventArgs e)
        {
            Form form = new TrangCaNhan_NVTiepNhan();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void trathongtindiem_Click(object sender, EventArgs e)
        {
            Form form = new Tracuuketquahp02();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void timthongtindkhp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gọi hàm PTTK_LayThongTinDKHocPhan từ tầng BUS_PTTK");
        }

        private void showlistdshvienhethong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gọi hàm PTTK_LayDSHocVien từ tầng BUS_PTTK");
        }
    }
}
