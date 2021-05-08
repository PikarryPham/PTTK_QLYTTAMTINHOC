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
    public partial class TrangCaNhan_NVTiepNhan : Form
    {
        public TrangCaNhan_NVTiepNhan()
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

        private void trangcn_tracuudiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newform = new Tracuuketquahp01();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
        }

        private void trangcn_huydkhp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newform = new Huythongtindkhocphan01();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
        }
    }
}
