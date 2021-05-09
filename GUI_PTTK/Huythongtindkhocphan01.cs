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
    public partial class Huythongtindkhocphan01 : Form
    {
        public Huythongtindkhocphan01()
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

        private void trathongtindiem_huythongtindk_Click(object sender, EventArgs e)
        {
            Form form = new Huythongtindkhocphan02();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void showlistdshvienhethong_huythongtindk_Click(object sender, EventArgs e)
        {
            dshocvien_huythongtindk.DataSource = BUS_HocVien.PTTK_LayDSHocVien();
        }

        private void timthongtindkhp_huythongtindk_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(cmnd_tracuu_huythongtindk.Text))
            {
                BUS_HocVien hv = new BUS_HocVien(cmnd_tracuu_huythongtindk.Text);
                chitietdkhocphan_huythongtindk.DataSource = BUS_DangKyHocPhan.PTTK_LayThongTinDKHocPhan(hv);
                if (BUS_DangKyHocPhan.ReturnCode == 1)
                {
                    MessageBox.Show(BUS_DangKyHocPhan.ReturnMess);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền vào CMND học viên");
            }
        }
    }
}
