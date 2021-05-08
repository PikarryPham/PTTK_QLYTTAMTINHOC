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
            MessageBox.Show("Gọi hàm PTTK_HuyDKHocPhan từ tầng BUS_PTTK");
        }
    }
}
