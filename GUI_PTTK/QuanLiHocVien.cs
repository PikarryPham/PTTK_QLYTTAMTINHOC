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
    public partial class QuanLiHocVien : Form
    {
        public QuanLiHocVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txbIDHV_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLiHocVien_Load(object sender, EventArgs e)
        {
            DSHocVien.DataSource = BUS_HocVien.LayDanhSachHocVien();
        }

        private void DSHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newform = new ThemHoSoHocVienMoi();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
        }

        private void btnSuaTTHV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbIDHV.Text))
            {
                MessageBox.Show("Vui lòng điền mã học viên cần sửa thông tin vào");
                return;
            }

            this.Hide();
            Form newform = new SuaThongTinHocVien();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
        }
    }
}
