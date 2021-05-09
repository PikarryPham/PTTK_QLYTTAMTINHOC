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
    public partial class Huythongtindkhocphan02 : Form
    {
        public Huythongtindkhocphan02()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void Huythongtindkhocphan02_Load(object sender, EventArgs e)
        {
            //nothing
        }

        private void backTrang_Click(object sender, EventArgs e)
        {
            Form form = new TrangCaNhan_NVTiepNhan();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void khongdongyhuyhpbtn_Click(object sender, EventArgs e)
        {
            Form form = new Huythongtindkhocphan01();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void dongyhuyhpbtn_Click(object sender, EventArgs e)
        {
            // Gọi hàm PTTK_HuyDKHocPhan từ tầng BUS_PTTK
            // không được PHÉP GỌI DAL_PTTK
            if(!string.IsNullOrEmpty(CMNDhocvien_xacnhanhuy.Text))
            {
                BUS_HocPhan hp = new BUS_HocPhan(Convert.ToInt32(idhocphan.Value));
                BUS_HocVien hv = new BUS_HocVien(CMNDhocvien_xacnhanhuy.Text);
                BUS_DangKyHocPhan dk = new BUS_DangKyHocPhan(ngaydk.Value.ToString());
                BUS_DangKyHocPhan.PTTK_HuyDKHocPhan(hv, hp, dk);
                if (BUS_DangKyHocPhan.ReturnCode == 1)
                {
                    MessageBox.Show(BUS_DangKyHocPhan.ReturnMess);
                }
                else
                {
                    MessageBox.Show(BUS_DangKyHocPhan.ReturnMess);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào CMND");
            }
        }
    }
}
