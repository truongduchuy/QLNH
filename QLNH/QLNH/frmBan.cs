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
    public partial class frmBan : Form
    {
        public frmBan()
        {
            InitializeComponent();
        }
        void LoadBan()
        {
            dtgvBan.Rows.Clear();
            List<Ban> list = BanBLL.Instance.Select_Ban();
            foreach (Ban b in list)
            {
                dtgvBan.Rows.Add(b.MaBan, b.TenBan, b.TinhTrang ? "Có Người" : "Trống");
            }
        }
        private void frmBan_Load(object sender, EventArgs e)
        {
            
            LoadBan();
        }
        void Clear()
        {
            txtMaban.Text = "";
            txtTenBan.Text = "";
            txtSearchBan.Text = "";
        }
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaban.Text = BanBLL.Instance.Ban_SelectNewID();
        }

        private void btnShowBan_Click(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void btnAddBan_Click(object sender, EventArgs e)
        {
            if(txtTenBan.Text == "")
            {
                MessageBox.Show("Tên Bàn Không được để trống");
            }
            else
            {
                try
                {
                    if (BanBLL.Instance.Insert_Ban(txtMaban.Text, txtTenBan.Text, rdTrong.Checked ? false : true) > 0)
                    {
                        MessageBox.Show("Thêm Thành công");
                    }
                    LoadBan();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.");
                }
            }
        }

        private void btnDeleteBan_Click(object sender, EventArgs e)
        {
            if (BanBLL.Instance.Delete_Ban(txtMaban.Text) > 0)
            {
                MessageBox.Show("Xóa Thành công");
            }
            LoadBan();
        }

        private void btnEditBan_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text == "")
            {
                MessageBox.Show("Tên Bàn Không được để trống");
            }
            else
            {
                try
                {
                    if (BanBLL.Instance.Update_Ban(txtMaban.Text, txtTenBan.Text, rdTrong.Checked ? false : true) > 0)
                    {
                        MessageBox.Show("Sửa Thành công");
                    }
                    LoadBan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.");
                }
            }
        }

        private void btnSearchBan_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvBan.Rows.Clear();
                DataTable dt = BanBLL.Instance.Search_Ban(txtSearchBan.Text);
                foreach (DataRow row in dt.Rows)
                {
                    dtgvBan.Rows.Add(row[0].ToString(), row[1].ToString(), Convert.ToBoolean(row[2].ToString())? "Có Người":"Trống");
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ.");
            }
        }

        private void dtgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dtgvBan.Rows[e.RowIndex];
                txtMaban.Text = row.Cells[0].Value.ToString();
                txtTenBan.Text = row.Cells[1].Value.ToString();
                string tinhTrang = row.Cells[2].Value.ToString();
                if (tinhTrang.Equals("Trống"))
                {
                    rdTrong.Checked = true;
                }
                else rdCoNguoi.Checked = true;
                     
            }
        }
    }
}
