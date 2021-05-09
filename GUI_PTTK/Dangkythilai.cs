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
    public partial class Dangkythilai : Form
    {
        public Dangkythilai()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void khongdongy_thilaibtn_Click(object sender, EventArgs e)
        {
            Form form = new Tracuuketquahp02();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void dongy_thilaibtn_Click(object sender, EventArgs e)
        {
            //B1. Goi ham kiem tra diem hoc phan
            //B2. Neu diem hoc phan <5 ==> di den UI Thong tin thi lai
            Form form = new Thongtinngaythilai();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
    }
}
