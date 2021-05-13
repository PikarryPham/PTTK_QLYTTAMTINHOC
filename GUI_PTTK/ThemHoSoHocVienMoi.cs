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
    public partial class ThemHoSoHocVienMoi : Form
    {
        public ThemHoSoHocVienMoi()
        {
            InitializeComponent();
        }

        private void labSuaTTHV_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTenHV.Text) || string.IsNullOrEmpty(txbCMND.Text) || string.IsNullOrEmpty(txbDiaChi.Text) ||
                string.IsNullOrEmpty(txbEmail.Text) || string.IsNullOrEmpty(txbSDT.Text) || (rbNam.Checked == false && rbNu.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            string gtinh;
            if (rbNam.Checked == true) gtinh = "Nam";
            else gtinh = "Nu";
            // Tao moi cac object
            BUS_HocVien hocvien = new BUS_HocVien(txbTenHV.Text,txbCMND.Text,gtinh,txbDiaChi.Text,txbEmail.Text,txbSDT.Text);
            datagridview_HVMoi.DataSource = BUS_HocVien.ThemHocVienMoi(hocvien);
            MessageBox.Show(BUS_HocVien.ReturnMess);
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form form = new QuanLiHocVien();
            form.Show();
            this.Close();
        }
    }
}
