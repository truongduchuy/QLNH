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
    public partial class frmChuyenBan : Form
    {
        public frmChuyenBan()
        {
            InitializeComponent();
        }

        private void frmChuyenBan_Load(object sender, EventArgs e)
        {
            List<Ban> list = BanBLL.Instance.Select_BanByTinhTrang(true);
            foreach (Ban ban in list)
            {
                cmbBanMuonChuyen.Items.Add(ban);
            }
            List<Ban> list2 = BanBLL.Instance.Select_BanByTinhTrang(false);
            foreach (Ban ban in list2)
            {
                cmbBanChuyenDen.Items.Add(ban);
            }

        }

        private void cmbBanMuonChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbBanChuyenDen.Items.Clear();
            //Ban b = cmbBanMuonChuyen.SelectedItem as Ban;
            //if (cmbBanMuonChuyen.SelectedIndex != -1)
            //{
            //    List<Ban> list = BanBLL.Instance.Select_BanByTinhTrang(true);
            //    foreach (Ban ban in list)
            //    {
            //        if(ban.MaBan != b.MaBan)
            //            cmbBanChuyenDen.Items.Add(ban);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbBanMuonChuyen.SelectedIndex != -1 && cmbBanChuyenDen.SelectedIndex != -1)
            {
                Ban b1 = cmbBanMuonChuyen.SelectedItem as Ban;
                Ban b2 = cmbBanChuyenDen.SelectedItem as Ban;
                string maHD = HoaDonBLL.Instance.Select_HoaDonChuaThanhToanByMaBan(b1.MaBan);
                if(maHD != "")
                {
                    HoaDonBLL.Instance.Update_HoaDonByMaBanAndMaHD(b2.MaBan, maHD);
                }
                BanBLL.Instance.Update_TinhTrangBan(false, b1.MaBan);
                BanBLL.Instance.Update_TinhTrangBan(true, b2.MaBan);
                MessageBox.Show("Chuyển bàn thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chọn bàn muốn chuyển và bàn chuyển đến");
            }
        }
    }
}
