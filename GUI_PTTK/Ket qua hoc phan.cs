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

            BUS_HocPhan hp = new BUS_HocPhan(ThongTinHocPhan._IDHocPhan);
            BUS_HocVien hv = new BUS_HocVien(ThongTinHV._CMND);
            BUS_DangKyHocPhan dk = new BUS_DangKyHocPhan(ThongTinDKHP._ngaydk);

            BUS_DangKyHocPhan.PTTK_ThongTinKhaiQuatDKHocPhan(hv,hp,dk);

            tenhpdky_inketqua.Text = BUS_DangKyHocPhan.TenHocPhan;
            thoigianbdhp_inketqua.Text = BUS_DangKyHocPhan.TGBD;
            diemhp_inketqua.Text = BUS_DangKyHocPhan.DiemHP;
            ngaydkhp_inketqua.Text = BUS_DangKyHocPhan.NgayDK;
            cmndhocvien.Text = BUS_DangKyHocPhan.CMNDHV;

            BUS_ChungChiHocPhan.PTTK_LayThongTinChungChi(hv, hp, dk);
            tenchungchi_inketqua.Text = BUS_ChungChiHocPhan.TenCC;
            ngaycapcc_inketqua.Text = BUS_ChungChiHocPhan.NgayCapCC;
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
