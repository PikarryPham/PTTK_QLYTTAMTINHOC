using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_PTTK;

namespace GUI_PTTK
{
    public partial class ThemkithiCCQT : Form
    {
        public ThemkithiCCQT()
        {
            InitializeComponent();
        }

        private void taomoibtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(diadiemthi.Text) || string.IsNullOrEmpty(tenkithiccqt.Text) || string.IsNullOrEmpty(ngaythiccqt.Text) ||
                string.IsNullOrEmpty(thoigianbdccqt.Text) || string.IsNullOrEmpty(thoigianlambai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            //DAL_KyThiCCQT da = new DAL_KyThiCCQT(diadiemthi.Text, tenkithiccqt.Text, ngaythiccqt.Text,)
        }
    }
}
