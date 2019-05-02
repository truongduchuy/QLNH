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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        DataTable dt;
        void LoadHoaDon()
        {
            Clear();
            dtgvHoaDon.Rows.Clear();
            dt = HoaDonBLL.Instance.Select_HoaDon();
            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayLap = Convert.ToDateTime(row["NgayHD"].ToString());
                bool TinhTrang = Convert.ToBoolean(row[2].ToString());
                dtgvHoaDon.Rows.Add(row[0].ToString(), ngayLap.ToString("MM/dd/yyyy HH:mm "),
                    TinhTrang? "Đã thanh toán":"Chưa thanh toán", row[3].ToString(), row[4].ToString());
            }
        }
        void LoadBan()
        {
            List<Ban> list = BanBLL.Instance.Select_Ban();
            foreach (Ban b in list)
            {
                cmbBan.Items.Add(b);
            }
        }
        void LoadTenDangNhap()
        {
            dt = NhanVienBLL.Instance.Select_NhanVien();
            foreach (DataRow row in dt.Rows)
            {
                cmbTenDangNhap.Items.Add(row["TenDangNhap"].ToString());
            }
        }
        void Clear()
        { 
            dtpkSearchHD.Value= DateTime.Now;
            txtMaHD.Text = "";
            dtpkNgayHD.Value = DateTime.Now;
            rdUnCheckOut.Checked = true;
            cmbBan.SelectedIndex = -1;
            cmbTenDangNhap.SelectedIndex = -1;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadBan();
            LoadTenDangNhap();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaHD.Text = HoaDonBLL.Instance.HoaDon_SelectNewID();
            btnAddHD.Enabled = true;
        }

        private void btnAddHH_Click(object sender, EventArgs e)
        {
            if(cmbBan.SelectedIndex == -1 || cmbTenDangNhap.SelectedIndex ==-1)
            {
                if(cmbBan.SelectedIndex == -1)
                {
                    MessageBox.Show("Chọn Bàn");
                    return;
                }
                else
                {
                    MessageBox.Show("Chọn Tên Đăng Nhập");
                    return;
                }
            }
            else
            {
                //try
                //{
                    string maBan = (cmbBan.SelectedItem as Ban).MaBan;

                    if (HoaDonBLL.Instance.Insert_HD(txtMaHD.Text,
                        dtpkNgayHD.Value, rdCheckOut.Checked ? true : false, maBan, cmbTenDangNhap.Text) > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadHoaDon();
                    }
                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show("Dữ liệu không hợp lệ");
                //}
            }
        }

        private void btnDeleteHH_Click(object sender, EventArgs e)
        {
            try
            {
                if (HoaDonBLL.Instance.Delete_HoaDon(txtMaHD.Text) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadHoaDon();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void btnEditHH_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                    string maBan = (cmbBan.SelectedItem as Ban).MaBan;

                    if (HoaDonBLL.Instance.Update_HoaDon(txtMaHD.Text,
                        dtpkNgayHD.Value, rdCheckOut.Checked ? true : false, maBan, cmbTenDangNhap.Text) > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadHoaDon();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ");
                }
            
        }

        private void btnShowHH_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void btnSearchHH_Click(object sender, EventArgs e)
        {
            dtgvHoaDon.Rows.Clear();
            dt = HoaDonBLL.Instance.Search_HoaDonByNgayLap(dtpkSearchHD.Value);
            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayLap = Convert.ToDateTime(row["NgayHD"].ToString());
                bool TinhTrang = Convert.ToBoolean(row[2].ToString());
                dtgvHoaDon.Rows.Add(row[0].ToString(), ngayLap.ToString("MM/dd/yyyy HH:mm "),
                    TinhTrang ? "Đã thanh toán" : "Chưa thanh toán", row[3].ToString(), row[4].ToString());
            }
        }

        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dtgvHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                dtpkNgayHD.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
                string tinhTrang = row.Cells[2].Value.ToString();
                if (tinhTrang.Equals("Đã thanh toán"))
                    rdCheckOut.Checked = true;
                else rdUnCheckOut.Checked = true;
                cmbBan.Text = row.Cells[3].Value.ToString();
                cmbTenDangNhap.Text = row.Cells[4].Value.ToString();
                btnAddHD.Enabled = false;
            }
        }
    }
}
