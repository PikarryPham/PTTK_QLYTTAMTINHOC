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
            if (!string.IsNullOrEmpty(cmnd.Text))
            {
                BUS_HocPhan hp = new BUS_HocPhan(Convert.ToInt32(idhocphan.Value));
                BUS_HocVien hv = new BUS_HocVien(cmnd.Text);
                BUS_DangKyHocPhan dk = new BUS_DangKyHocPhan(ngaydk.Value.ToString());
                dataGridView1.DataSource = BUS_DangKyHocPhan.PTTK_ThongTinChiTietDKHocPhan(hv, hp, dk);
                tbdenhocvien.Text = BUS_DangKyHocPhan.THONGBAODAUROT;
                if(BUS_DangKyHocPhan.ReturnCode == 1)
                {
                    MessageBox.Show(BUS_DangKyHocPhan.ReturnMess);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống trường CMND");
            }
        }

        private void inkqhocphan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmnd.Text))
            {
                
                BUS_HocVien hv = new BUS_HocVien(cmnd.Text);
                int idhocvien = BUS_HocVien.PTTK_LayIDHocVien(hv);

                //MessageBox.Show("Id cua hoc vien nay la " + idhocvien);
                BUS_HocPhan hp = new BUS_HocPhan(Convert.ToInt32(idhocphan.Value));
                BUS_HocVien hvien = new BUS_HocVien(idhocvien);
                BUS_DangKyHocPhan dk = new BUS_DangKyHocPhan(ngaydk.Value.ToString());

                

                int ketquaDiemThi = BUS_DangKyHocPhan.PTTK_KiemTraDiemHocPhan(hvien, hp, dk);
                //MessageBox.Show("Ket qua diem thi la " + ketquaDiemThi);
                if(ketquaDiemThi == -1)
                {
                    MessageBox.Show("Chưa có điểm thi. Không thể in kết quả học phần");
                }
                else if(ketquaDiemThi == 0)
                {
                    MessageBox.Show("Kết quả của bạn là không đạt. Vui lòng đạt để được in kết quả");
                }
                else
                {
                    ThongTinHV._CMND = cmnd.Text;
                    ThongTinHocPhan._IDHocPhan = Convert.ToInt32(idhocphan.Value);
                    ThongTinDKHP._ngaydk = ngaydk.Value.ToString();
                    Form form = new Inketquahocphan();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Không được để trống trường CMND");
            }
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
                else if(isValid == -2)
                {
                    MessageBox.Show("Bạn chưa có điểm thi.");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống trường CMND");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nothing
        }
    }
}
