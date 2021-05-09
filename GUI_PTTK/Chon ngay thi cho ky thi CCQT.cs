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
    public partial class Chon_ngay_thi_cho_ky_thi_CCQT : Form
    {
        public Chon_ngay_thi_cho_ky_thi_CCQT()
        {
            InitializeComponent();
            username.Text = ThongTinNV._username;
        }

        private void backTrangTaomoi_Click(object sender, EventArgs e)
        {
            Form form = new TrangCaNhan_QuanLy();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void showlistkithiccqt_chinhsuangaythi_Click(object sender, EventArgs e)
        {
            chinhsuangaythi_dskithiCCQT.DataSource = BUS_KyThiCCQT.PTTK_LayDanhSachKyThiCCQT();
        }

        private void timdscacngaythi_chinhsuangaythikithiccqt_Click(object sender, EventArgs e)
        {
            BUS_NgayThiKyThiCCQT ngaythichungchiqt = new BUS_NgayThiKyThiCCQT(Convert.ToInt32(makithiccqt_quanli.Value));
            int result = BUS_NgayThiKyThiCCQT.PTTK_KiemTraMaKiThiCCQT(ngaythichungchiqt);
            if(result != 0)
            {
                dataGridView1.DataSource = BUS_NgayThiKyThiCCQT.PTTK_LayDanhSachCacNgayThiCCQT(ngaythichungchiqt);
                //MessageBox.Show(result.ToString());
            }
            else
            {
                MessageBox.Show("Khong ton tai ma ky thi CCQT nay");
            }
        }

        private void themngaythi_btn_Click(object sender, EventArgs e)
        {
            if(makithiccqt_quanli.Value.ToString() != null  && ngaythimoi_textbox.Value.ToString() != null)
            {
                BUS_NgayThiKyThiCCQT ngaythichungchiqt = new BUS_NgayThiKyThiCCQT(Convert.ToInt32(makithiccqt_quanli.Value), ngaythimoi_textbox.Value.ToString());
                int result = BUS_NgayThiKyThiCCQT.PTTK_KiemTraMaKiThiCCQT(ngaythichungchiqt);
                if(result != 0)
                {
                    BUS_NgayThiKyThiCCQT.PTTK_ThemNgayThiMoi(ngaythichungchiqt);
                    if (BUS_NgayThiKyThiCCQT.ReturnCode == 0)
                    {
                        MessageBox.Show(BUS_NgayThiKyThiCCQT.ReturnMess);
                    }
                    else
                    {
                        MessageBox.Show(BUS_NgayThiKyThiCCQT.ReturnMess);
                    }
                }
                else
                {
                    MessageBox.Show("Khong ton tai ma ky thi CCQT nay");
                }
            }
        }

        private void xoangaythi_btn_Click(object sender, EventArgs e)
        {
            if (makithiccqt_quanli.Value.ToString() != null && xoangaythi_txt.Value.ToString() != null)
            {
                BUS_NgayThiKyThiCCQT ngaythichungchiqt = new BUS_NgayThiKyThiCCQT(Convert.ToInt32(makithiccqt_quanli.Value), xoangaythi_txt.Value.ToString());
                int result = BUS_NgayThiKyThiCCQT.PTTK_KiemTraMaKiThiCCQT(ngaythichungchiqt);
                if(result != 0)
                {
                    BUS_NgayThiKyThiCCQT.PTTK_XoaNgayThiHienTai(ngaythichungchiqt);
                    if (BUS_NgayThiKyThiCCQT.ReturnCode == 0)
                    {
                        MessageBox.Show(BUS_NgayThiKyThiCCQT.ReturnMess);
                    }
                    else
                    {
                        MessageBox.Show(BUS_NgayThiKyThiCCQT.ReturnMess);
                    }
                }
                else
                {
                    MessageBox.Show("Khong ton tai ma ky thi CCQT nay");
                }
            }
        }

        private void suangaythi_btn_Click(object sender, EventArgs e)
        {
            if (makithiccqt_quanli.Value.ToString() != null && ngaythicu.Value.ToString() != null && ngaythimoi.Value.ToString() != null)
            {
                BUS_NgayThiKyThiCCQT ngaythichungchiqtcu = new BUS_NgayThiKyThiCCQT(Convert.ToInt32(makithiccqt_quanli.Value), ngaythicu.Value.ToString());
                BUS_NgayThiKyThiCCQT ngaythichungchiqtmoi = new BUS_NgayThiKyThiCCQT(Convert.ToInt32(makithiccqt_quanli.Value), ngaythimoi.Value.ToString());
                
                int resultcu = BUS_NgayThiKyThiCCQT.PTTK_KiemTraMaKiThiCCQT(ngaythichungchiqtcu);
                int resultmoi = BUS_NgayThiKyThiCCQT.PTTK_KiemTraMaKiThiCCQT(ngaythichungchiqtmoi);
                if(resultcu != 0 && resultmoi != 0)
                {
                    BUS_NgayThiKyThiCCQT.PTTK_CapNhatNgayThi(ngaythichungchiqtcu, ngaythichungchiqtmoi);
                    if (BUS_NgayThiKyThiCCQT.ReturnCode == 0)
                    {
                        MessageBox.Show(BUS_NgayThiKyThiCCQT.ReturnMess);
                    }
                    else
                    {
                        MessageBox.Show(BUS_NgayThiKyThiCCQT.ReturnMess);
                    }
                }
                else
                {
                    MessageBox.Show("Khong ton tai ma ky thi CCQT nay");
                }
                
            }
        }

        
    }
}
