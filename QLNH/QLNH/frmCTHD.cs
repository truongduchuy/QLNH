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
    public partial class frmCTHD : Form
    {
        public static string MaHoaDon = "";
        //DataTable dt;
        public frmCTHD()
        {
            InitializeComponent();
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            LoadLoaiHang();
            LoadHoaDonBan();
            TinhTongTien();
        }
        private void LoadHoaDonBan()
        {
            dtgvCTHD.Rows.Clear();
            DataTable dt = CTHD_BLL.Instance.Select_HoaDonBanByMa(frmMain.ban.MaBan);
            foreach (DataRow row in dt.Rows)
            {
                //dtgvCTHD.Rows.Add(row.TenHang, item.DonGia, item.SL, item.ThanhTien);
                dtgvCTHD.Rows.Add(row["TenHang"], row["DonGia"], row["SL"], row["ThanhTien"]);
            }
        }
        private void LoadLoaiHang()
        {
            cmbLoaiHang.DataSource = LoaiHangBLL.Instance.Select_LoaiHang();
            cmbLoaiHang.DisplayMember = "TenLH";
            
        }
        private void LoadHangHoa()
        {
            LoaiHang lh = cmbLoaiHang.SelectedItem as LoaiHang;
            if (cmbLoaiHang.SelectedIndex != -1)
            {
                List<HangHoa> listHH = HangHoaBLL.Instance.Select_HangHoaByMaLH(lh.MaLH);
                foreach (HangHoa hh in listHH)
                {
                    lstHangHoa.Items.Add(hh);
                }
            }
        }
        private void TinhTongTien()
        {
            int sum = 0;
            foreach (DataGridViewRow item in dtgvCTHD.Rows)
            {
                sum += (int)item.Cells[3].Value;
            }
            txtTongTien.Text = sum.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHangHoa.Items.Clear();
            LoadHangHoa();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(lstHangHoa.SelectedIndex !=-1)
            {
                string maBan = frmMain.ban.MaBan;
                string maHD = HoaDonBLL.Instance.Select_HoaDonChuaThanhToanByMaBan(maBan);
                string maHang = (lstHangHoa.SelectedItem as HangHoa).MaHang;
             
                int SL = (int)nmrSL.Value;
                if (maHD.Equals(""))
                {
                    HoaDonBLL.Instance.Insert_HoaDon(maBan, frmMain.TenDangNhap.Trim());
                    if(CTHD_BLL.Instance.Insert_CTHD(HoaDonBLL.Instance.Get_MaxMaHD(), maHang, SL) <= 0)
                    {
                        if (SL <= 0)
                        {
                            MessageBox.Show("Số lượng phải lớn hơn 0");
                        }
                        else
                            MessageBox.Show("Không được vượt quá số lượng còn"); 
                    }
                    
                    
                }
                else
                {
                    if(CTHD_BLL.Instance.Insert_CTHD(maHD, maHang, SL) <= 0)
                    {
                        if(SL <=0)
                        {
                            MessageBox.Show("Số lượng phải lớn hơn 0");
                        }
                        else
                        MessageBox.Show("Không được vượt quá số lượng còn");
                    }

                }
                LoadHoaDonBan();
                TinhTongTien();
            }
            

        }

        private void frmCTHD_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maHD = HoaDonBLL.Instance.Select_HoaDonChuaThanhToanByMaBan(frmMain.ban.MaBan);
            MaHoaDon = maHD;
            HoaDonBLL.Instance.Update_TinhTrangHDByMaHD(maHD);
            BanBLL.Instance.Update_TinhTrangBan(false, frmMain.ban.MaBan);
            
            this.Hide();
            DialogResult rs = MessageBox.Show("" +
                "Bạn có muốn in hóa đơn không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                frmInHoaDon frm = new frmInHoaDon();
                frm.ShowDialog();
            }
        }
    }
}
