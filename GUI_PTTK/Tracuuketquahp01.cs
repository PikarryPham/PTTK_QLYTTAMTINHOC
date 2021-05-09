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
            if(!string.IsNullOrEmpty(CMNDhocvien_tracuu.Text))
            {
                BUS_HocVien hv = new BUS_HocVien(CMNDhocvien_tracuu.Text);
                chitietdkhocphan.DataSource = BUS_DangKyHocPhan.PTTK_LayThongTinDKHocPhan(hv);
                if(BUS_DangKyHocPhan.ReturnCode == 1)
                {
                    MessageBox.Show(BUS_DangKyHocPhan.ReturnMess);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền vào CMND học viên");
            }
        }

        private void showlistdshvienhethong_Click(object sender, EventArgs e)
        {
            //BUS_HocVien hv = new BUS_HocVien();
            dshocvien_tracuu.DataSource = BUS_HocVien.PTTK_LayDSHocVien();
        }
    }
}
