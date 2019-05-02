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
    public partial class frmMain : Form
    {
        public static Ban ban;
        public static string TenDangNhap;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTable();
            TenDangNhap = lblTenDangNhap.Text = frmLogin.TenDangNhap;
            string Quyen = NhanVienBLL.Instance.GetQuyenByTenDangNhap(TenDangNhap);
            if (Quyen.Equals("Admin"))
            {
                ShowButton();
            }
               
            
        }
        void ShowButton()
        {
            btnNhanVien.Enabled = true;
            btnLoaihang.Enabled = true;
            btnHangHoa.Enabled = true;
            btnHoaDon.Enabled = true;
            btnBan.Enabled = true;
            btnDoanhThu.Enabled = true;
        }
        private void LoadTable()
        {
            List<Ban> listBan = BanBLL.Instance.Select_Ban();
            flpTable.Controls.Clear();
            foreach (Ban b in listBan)
            {
                Button btn = new Button() { Width = 100, Height= 100 };
                btn.Text = b.TenBan;
                btn.Click += btn_Click;
                btn.Tag = b;
                if (b.TinhTrang == true)
                {
                    btn.BackColor = Color.Aqua;
                }
                else btn.BackColor = Color.AliceBlue;
                flpTable.Controls.Add(btn);
            }
            
        }

        void btn_Click(object sender, EventArgs e)
        {
            
            ban = (sender as Button).Tag as Ban;
            if(ban.TinhTrang == true)
            {
                frmCTHD frm = new frmCTHD();
                frm.ShowDialog();
                LoadTable();
                btnMoBan.Enabled = false;
            }
            else
            {
                btnMoBan.Enabled = true;
            }
               
            

        }
       
        

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            // neu ban trong > 0
            if(BanBLL.Instance.Count_BanByTinhTrang(true) > 0)
            {
                frmHuyBan frm = new frmHuyBan();
                frm.ShowDialog();
                LoadTable();
            }
            else
            {
                MessageBox.Show("Chưa có bàn nào hoạt động");
            }
            
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            // không có bàn trống
            if(BanBLL.Instance.Count_BanByTinhTrang(false) == 0)
            {
                MessageBox.Show("Không có bàn để chuyển");
            }
            // co it nhat 1 ban hoạt động
            else if(BanBLL.Instance.Count_BanByTinhTrang(true) > 0)
            {
                frmChuyenBan frm = new frmChuyenBan();
                frm.ShowDialog();
                LoadTable();
            }
            else if(BanBLL.Instance.Count_BanByTinhTrang(true) == 0)
            {
                MessageBox.Show("Chưa có bàn nào hoạt động");
            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {

            if (BanBLL.Instance.Count_BanByTinhTrang(true) == 0)
            {
                MessageBox.Show("Chưa có bàn nào hoạt động");
            }
            else
            {
                if (BanBLL.Instance.Count_BanByTinhTrang(true) >=2)
                {
                    frmGopBan frm = new frmGopBan();
                    frm.ShowDialog();
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Phải có ít nhất 2 bàn mới có thể gộp");
                }
            }
            

        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {
            BanBLL.Instance.Update_TinhTrangBan(true, ban.MaBan);
            frmCTHD frm = new frmCTHD();
            frm.ShowDialog();
            btnMoBan.Enabled = false;
            LoadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void btnLoaihang_Click(object sender, EventArgs e)
        {
            frmLoaiHang frm = new frmLoaiHang();
            frm.ShowDialog();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            frm.ShowDialog();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            frmBan frm = new frmBan();
            frm.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu frm = new frmDoanhThu();
            frm.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
