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
           
            Form form = new Ket_qua_hoc_phan();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
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
