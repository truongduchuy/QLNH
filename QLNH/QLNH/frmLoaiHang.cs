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
    public partial class frmLoaiHang : Form
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }
        void LoadLoaiHang()
        {
            dtgvLoaiHang.Rows.Clear();
            List<LoaiHang> listLH = LoaiHangBLL.Instance.Select_LoaiHang();
            foreach (LoaiHang lh in listLH)
            {
                dtgvLoaiHang.Rows.Add(lh.MaLH, lh.TenLH);
            }
        }
        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            LoadLoaiHang();
        }

        private void btnAddLH_Click(object sender, EventArgs e)
        {
            if(txtTenLH.Text=="")
            {
                MessageBox.Show("Tên loại hàng không được để trô");
            }
            else
            {
                try
                {
                    if (LoaiHangBLL.Instance.Insert_LoaiHang(txtTenLH.Text) > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                    }

                    LoadLoaiHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ");
                }
            }

        }

        private void btnDeleteLH_Click(object sender, EventArgs e)
        {
            if (LoaiHangBLL.Instance.Delete_LoaiHang(txtMaLH.Text) > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
           
            LoadLoaiHang();

        }

        private void btnEditLH_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoaiHangBLL.Instance.Update_LoaiHang(txtMaLH.Text, txtTenLH.Text) > 0)
                {
                    MessageBox.Show("Sủa thành công");
                }

                LoadLoaiHang();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        
        }

        private void btnShowLH_Click(object sender, EventArgs e)
        {
            
            LoadLoaiHang();
        }

        private void btnSearchLH_Click(object sender, EventArgs e)
        {
            dtgvLoaiHang.Rows.Clear();
            List<LoaiHang> list = LoaiHangBLL.Instance.Search_LoaiHang(txtSearchLH.Text);
            foreach(LoaiHang lh in list)
            {
                dtgvLoaiHang.Rows.Add(lh.MaLH, lh.TenLH);
            }
            

        }

        private void dtgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvLoaiHang.Rows[e.RowIndex];
                txtMaLH.Text = row.Cells[0].Value.ToString();
                txtTenLH.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
