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
    public partial class Inketquahocphan : Form
    {
        public Inketquahocphan()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void dongy_inkqhpBtn_Click(object sender, EventArgs e)
        {
            //B1. Goi ham BUS_KiemTraDiemHocPhan de kiem tra diem hoc phan co >= 5 khong?
            //B2. Neu diem >=5 thi moi cho phep in ket qua hoc phan (xem them trong activity diagram)
            MessageBox.Show("Goi ham PTTK_KiemTraDiemHocPhan tu BUS_PTTK de kiem tra diem hoc phan co >= 5 khong?");
            MessageBox.Show("Neu diem >=5 thi moi cho phep di den UI Ket qua hoc phan");
            bool isValid = true; //Neu kiem tra thay diem >=5
            if(isValid)
            {
                Form form = new Ket_qua_hoc_phan();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Close();
            }
            else
            {
                //Thong bao khong du tieu chuan de in ket qua hoc phan
            }
        }

        private void khongdongy_inkqhpBtn_Click(object sender, EventArgs e)
        {
            Form form = new Tracuuketquahp02();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
    }
}
