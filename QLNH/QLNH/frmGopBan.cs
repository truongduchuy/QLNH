using ClassLibrary1;
using QLNH_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class frmGopBan : Form
    {
        public frmGopBan()
        {
            InitializeComponent();
        }

        private void frmGopBan_Load(object sender, EventArgs e)
        {
            List<Ban> list = BanBLL.Instance.Select_BanByTinhTrang(true);
            foreach (Ban ban in list)
            {
                cmbBanMuonGop.Items.Add(ban);
            }
        }

        private void cmbBanMuonGop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ban b = cmbBanMuonGop.SelectedItem as Ban;
            List<Ban> list = BanBLL.Instance.Select_BanByTinhTrang(true);
            foreach (Ban ban in list)
            {
                if (ban.MaBan != b.MaBan)
                    cmbBanGop.Items.Add(ban);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbBanMuonGop.SelectedIndex != -1 && cmbBanGop.SelectedIndex != -1)
            {
                Ban b1 = cmbBanMuonGop.SelectedItem as Ban;
                Ban b2 = cmbBanGop.SelectedItem as Ban;
                string maHD1 = HoaDonBLL.Instance.Select_HoaDonChuaThanhToanByMaBan(b1.MaBan);
                string maHD2 = HoaDonBLL.Instance.Select_HoaDonChuaThanhToanByMaBan(b2.MaBan);
                
                if (maHD1 != "")
                {
                    if (maHD2 != "")
                    {
                        List<CTHD> listCTHD1 = CTHD_BLL.Instance.Select_CTHDByMaHD(maHD1);
                        List<CTHD> listCTHD2 = CTHD_BLL.Instance.Select_CTHDByMaHD(maHD2);
                        foreach (CTHD cthd1 in listCTHD1)
                        {
                            foreach (CTHD cthd2 in listCTHD2)
                            {
                                if (cthd1.MaHang.Equals(cthd2.MaHang))
                                {
                                    CTHD_BLL.Instance.Update_CTHD(cthd2.MaHD, cthd2.MaHang, cthd1.SL + cthd2.SL);
                                }
                                else
                                {
                                    CTHD_BLL.Instance.Insert_CTHDByMa(cthd2.MaHD, cthd1.MaHang, cthd1.SL);
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        HoaDonBLL.Instance.Update_HoaDonByMaBanAndMaHD(b2.MaBan, maHD1);
                    }

                }
                BanBLL.Instance.Update_TinhTrangBan(false, b1.MaBan);
                MessageBox.Show("Gop ban thanh cong");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chọn 2 bàn muốn gộp");
            }
        }
    }
}
