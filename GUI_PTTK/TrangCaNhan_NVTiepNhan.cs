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
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {

        }

        private void TrangCaNhan_NVTiepNhan_Load(object sender, EventArgs e)
        {

        }

        private void QLHV_Click(object sender, EventArgs e)
        {
             this.Hide();
            Form newform = new QuanLiHocVien();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
        }
    }
}
