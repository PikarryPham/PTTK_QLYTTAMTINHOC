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
    public partial class Tracuuketquahp02 : Form
    {
        public Tracuuketquahp02()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void backTrang_Click(object sender, EventArgs e)
        {
            Form form = new Tracuuketquahp01();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void tracuudiemkqhp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gọi hàm PTTK_ThongTinChiTietDKHocPhan từ BUS_PTTK");
        }

        private void inkqhocphan_Click(object sender, EventArgs e)
        {
            Form form = new Inketquahocphan();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void dkthilai_Click(object sender, EventArgs e)
        {
            Form form = new Dangkythilai();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
    }
}
