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
    public partial class frmHuyBan : Form
    {
        public frmHuyBan()
        {
            InitializeComponent();
        }

        private void frmHuyBan_Load(object sender, EventArgs e)
        {
            List<Ban> list = BanBLL.Instance.Select_BanByTinhTrang(true);
            foreach (Ban ban in list)
            {
                cmbBanCoNguoi.Items.Add(ban);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbBanCoNguoi.SelectedIndex != -1)
            {
                string maBan = (cmbBanCoNguoi.SelectedItem as Ban).MaBan;
                string maHD = HoaDonBLL.Instance.Select_HoaDonChuaThanhToanByMaBan(maBan);
                if (maHD != "")
                {

                    HoaDonBLL.Instance.Delete_HoaDonChuaThanhToanByMaHD(maHD);
                    MessageBox.Show("Hủy bàn thành công");
                }
                else
                {
                    BanBLL.Instance.Update_TinhTrangBan(false, maBan);
                    MessageBox.Show("Hủy bàn thành công");
                }
                BanBLL.Instance.Update_TinhTrangBan(false, maBan);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chọn bàn muốn hủy");
            }
        }

        private void frmHuyBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
        }
    }
}
