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
    public partial class Ket_qua_hoc_phan : Form
    {
        public Ket_qua_hoc_phan()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Tracuuketquahp01();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
        //Hiển thị thông tin lên các trường label text trên UI
        // Đối với thông tin chứng chỉ, gọi hàm PTTK_LayThongTinChungChi từ BUS_PTTK
        // Đối với thông tin kq học phần, gọi hàm PTTK_ThongTinKhaiQuatDKHocPhan từ BUS_PTTK
    }
}
