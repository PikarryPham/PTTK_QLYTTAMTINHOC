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
            //B1. Goi ham kiem tra diem hoc phan
            //B2. Kiem tra so lan thi lai co hop le khong
            //B3. Neu diem hoc phan <5 ==> di den UI Thong tin thi lai
            int isValid = 0;
            if(!string.IsNullOrEmpty(cmnd.Text))
            {
                BUS_HocPhan hp = new BUS_HocPhan(Convert.ToInt32(idhocphan.Value));
                BUS_HocVien hv = new BUS_HocVien(cmnd.Text);
                BUS_DangKyHocPhan dk = new BUS_DangKyHocPhan(ngaydk.Value.ToString());
                isValid = BUS_DangKyHocPhan.PTTK_KiemTraDuocThiLai(hv, hp, dk);
                //MessageBox.Show(isValid.ToString());
                if(isValid == 1)
                {
                    Form form = new Dangkythilai();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                    this.Close();
                }
                else if(isValid == -1)
                {
                    MessageBox.Show("Chỉ cho phép được thi lại nếu điểm < 5");
                }
                else if(isValid == 0)
                {
                    MessageBox.Show("Không được thi lại nữa vì đã thi lại 3 lần rồi");
                }
            }
        }
    }
}
