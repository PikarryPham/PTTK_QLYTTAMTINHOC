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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // Tao object nay de goi ham
        
        private void loginhthong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginusername.Text) || string.IsNullOrEmpty(loginpassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (!logingiaovien.Checked && !logintiepnhan.Checked && !loginquanli.Checked && !nhanvienketoan.Checked && !loginbophanvp.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản đăng nhập");
                return;
            }
            if(loginquanli.Checked)
            {
                // Tao mot object DAL_ThongTinTKNhanVien (dung constructor co truyen vao day du tham so)
                BUS_ThongTinTKNhanVien da = new BUS_ThongTinTKNhanVien(loginusername.Text, loginpassword.Text, 1); //quan li co typenv la 1
                // Do khai bao la static nen co the goi thang tenclass.tenham ma k can khoi tao doi tuong
                BUS_ThongTinTKNhanVien.PTTK_KiemTraThongTinDauVao(da);
                if (BUS_ThongTinTKNhanVien.ReturnCode == 0)
                {
                    Form form = new TrangCaNhan_QuanLy();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                    this.Close();
                }
                else
                    MessageBox.Show(BUS_ThongTinTKNhanVien.ReturnMess);
                return;
            }
            else
            {
                MessageBox.Show("ahihi");
            }
        }
    }
}
