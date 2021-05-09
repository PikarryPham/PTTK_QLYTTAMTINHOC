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
    public partial class Thongtinngaythilai : Form
    {
        public Thongtinngaythilai()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void Thongtinngaythilai_Load(object sender, EventArgs e)
        {
            //do sthig
            
        }

        private void backquayvetrangchu_Click(object sender, EventArgs e)
        {
            Form form = new Tracuuketquahp02();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Button Dang Ky Thi Lai
        {
            if (string.IsNullOrEmpty(madkhocphan.Text) || string.IsNullOrEmpty(ngaythimoi_textbox.Text) || string.IsNullOrEmpty(phong.Text) ||
                string.IsNullOrEmpty(thoigianbd.Text) || string.IsNullOrEmpty(thgianlambai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            BUS_LichThiLai x = new BUS_LichThiLai(Convert.ToInt32(madkhocphan.Value), ngaythimoi_textbox.Value.ToString(), phong.Text, thoigianbd.Text, Convert.ToInt32(thgianlambai.Value));
            thongtinlichthilai.DataSource = BUS_LichThiLai.PTTK_GhiNhanThongTinLichThiLai(x);
            MessageBox.Show(BUS_LichThiLai.ReturnMess);
        }
    }
}
