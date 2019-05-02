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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        void LoadLoaiHang()
        {
            List<LoaiHang> list = LoaiHangBLL.Instance.Select_LoaiHang();
            foreach (LoaiHang lh in list)
            {
                cmbLoaiHang.Items.Add(lh);
            }
        }
        void LoadHangHoa()
        {
            dtgvHangHoa.DataSource = HangHoaBLL.Instance.Select_HangHoa();
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
            LoadLoaiHang();

        }

        private void btnAddHH_Click(object sender, EventArgs e)
        {
            if(txtTenHang.Text ==""||txtDonGia.Text==""||txtSLCon.Text==""||cmbLoaiHang.SelectedIndex == -1)
            {
                if (txtTenHang.Text == "")
                {
                    MessageBox.Show("Tên Hàng không được để trống");
                    return;
                }
                else if(txtDonGia.Text =="")
                {
                    MessageBox.Show("Đơn Giá không được để trống");
                    return;
                }
                else if(txtSLCon.Text =="")
                {
                    MessageBox.Show("Số Lượng Còn không được để trống");
                    return;
                }
                else
                {
                    MessageBox.Show("Chưa chọn loại hàng");
                    return;
                }
            }
            else
            {
                string maLH = (cmbLoaiHang.SelectedItem as LoaiHang).MaLH;
                try
                {
                    if (HangHoaBLL.Instance.Insert_HangHoa(txtMaHang.Text,
                    txtTenHang.Text, int.Parse(txtDonGia.Text), int.Parse(txtSLCon.Text), maLH) > 0)
                    {
                        MessageBox.Show("Thêm Thành Công");
                    }
                    LoadHangHoa();
                }
                catch(Exception ex)
                {
                    if(txtMaHang.Text != HangHoaBLL.Instance.HangHoa_SelectNewID())
                    {
                        MessageBox.Show("Mã Hàng Hóa đã tồn tại");
                    }
                    else MessageBox.Show("Dữ liệu không hợp lệ");
                }
            }
        }

        private void btnDeleteHH_Click(object sender, EventArgs e)
        {
            if (HangHoaBLL.Instance.Delete_HangHoa(txtMaHang.Text) > 0)
            {
                MessageBox.Show("Xóa Thành Công");
                LoadHangHoa();
            }
        }

        private void btnEditHH_Click(object sender, EventArgs e)
        {
            string maLH = (cmbLoaiHang.SelectedItem as LoaiHang).MaLH;
            try
            {
                if (HangHoaBLL.Instance.Update_HangHoa(txtMaHang.Text,
                txtTenHang.Text, int.Parse(txtDonGia.Text), int.Parse(txtSLCon.Text), maLH) > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                }
                LoadHangHoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }


        private void btnSearchHH_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvHangHoa.DataSource = HangHoaBLL.Instance.Search_HangHoa(txtSearchHH.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
}

        private void dtgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvHangHoa.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells[0].Value.ToString();
                txtTenHang.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                txtSLCon.Text = row.Cells[3].Value.ToString();
                cmbLoaiHang.Text = row.Cells[4].Value.ToString();

            }
        }
        void Clear()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtDonGia.Text = "";
            txtSLCon.Text = "";
            cmbLoaiHang.SelectedIndex = -1;
            txtSearchHH.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaHang.Text = HangHoaBLL.Instance.HangHoa_SelectNewID();
        }

        private void btnShowHH_Click_1(object sender, EventArgs e)
        {
            LoadHangHoa();
        }
    }
}
