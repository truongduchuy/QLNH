using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class frmNhanVien : Form
    {
        byte[] img = null;
        DataTable dt;
        string imgPath = "";

        public frmNhanVien()
        {
            InitializeComponent();
        }
       
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        void Clear()
        {
            imgPath = "";
            picNV.Image = null;
            txtTenDangNhap.Text = "";
            txtTenNhanVien.Text = "";
            txtPassWord.Text = "";
            txtQuyen.Text = "";
            
        }
        void LoadNhanVien()
        {
            Clear();
            dtgvNhanVien.Rows.Clear();
            dt = NhanVienBLL.Instance.Select_NhanVien();
            foreach (DataRow row in dt.Rows)
            {
                dtgvNhanVien.Rows.Add(row["TenDangNhap"].ToString(), row["TenNhanVien"].ToString(), row["Quyen"].ToString());
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            
            if(imgPath == "" || txtTenDangNhap.Text == ""||txtTenNhanVien.Text==""||txtPassWord.Text==""||txtQuyen.Text =="")
            {
                if(imgPath == "")
                {
                    MessageBox.Show("Chọn Ảnh trước khi thêm.");
                    return;
                }
                else if(txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập không được để trống.");
                    return;
                }
                else if(txtTenNhanVien.Text == "")
                {
                    MessageBox.Show("Tên nhân viên không được để trống");
                    return;
                }
                else if (txtPassWord.Text == "")
                {
                    MessageBox.Show("Tên mật khẩu không được để trống.");
                    return;
                }
                else
                {
                    MessageBox.Show("Quyền nhân viên không được để trống.");
                    return;
                }
            }
            else
            {
                try
                {
                    // chuyen file anh ve byte[]
                    FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    if (NhanVienBLL.Instance.Insert_NhanVien(txtTenDangNhap.Text, txtTenNhanVien.Text, txtPassWord.Text, txtQuyen.Text, img) > 0)
                    {
                        MessageBox.Show("Them thanh cong.");
                        LoadNhanVien();
                        btnAddNV.Enabled = false;
                    }
                }
                catch(Exception ex)
                {
                    DataTable dt = NhanVienBLL.Instance.Select_NhanVienByTenDN(txtTenDangNhap.Text);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tên Đăng Nhập đã tồn tại.");
                    }
                    else
                     MessageBox.Show("Dữ liệu không hợp lệ.");
                }
            }
            
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text != "")
            {
                if (NhanVienBLL.Instance.Delete_NhanVien(txtTenDangNhap.Text) > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    LoadNhanVien();
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên muốn xóa.");
            }
            
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgPath != "")
                {
                    FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    if (NhanVienBLL.Instance.Update_NhanVien(txtTenDangNhap.Text, txtTenNhanVien.Text, txtPassWord.Text, txtQuyen.Text, img) > 0)
                    {
                        MessageBox.Show("Sửa thành công.");

                    }
                }
                else
                {
                    if (NhanVienBLL.Instance.Update_NhanVienNoImg(txtTenDangNhap.Text, txtTenNhanVien.Text, txtPassWord.Text, txtQuyen.Text) > 0)
                    {
                        MessageBox.Show("Sửa thành công.");

                    }
                }
                LoadNhanVien();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ.");
            }
        }

        private void btnShowNV_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvNhanVien.Rows.Clear();
                dt = NhanVienBLL.Instance.Search_NhanVienByTenDN(txtSearchNV.Text);
                foreach (DataRow row in dt.Rows)
                {
                    dtgvNhanVien.Rows.Add(row["TenDangNhap"], row["TenNhanVien"], row["Quyen"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ.");
            }
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddNV.Enabled = false;
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = dtgvNhanVien.Rows[e.RowIndex];
                string tenDangNhap = row.Cells[0].Value.ToString();
                dt = NhanVienBLL.Instance.Select_NhanVienByTenDN(tenDangNhap);
                txtTenDangNhap.Text = dt.Rows[0]["TenDangNhap"].ToString();
                txtTenNhanVien.Text = dt.Rows[0]["TenNhanVien"].ToString();
                txtPassWord.Text = dt.Rows[0]["MatKhau"].ToString();
                txtQuyen.Text = dt.Rows[0]["Quyen"].ToString();
                if(dt.Rows[0]["Anh"].ToString() != "")
                {
                    img = (byte[])(dt.Rows[0]["Anh"]);
                    MemoryStream ms = new MemoryStream(img);
                    picNV.Image = Image.FromStream(ms);
                }
                else
                    picNV.Image = null;

            }
        }
        
        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgPath = dlg.FileName.ToString();
                    picNV.ImageLocation = imgPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            Clear();
            btnAddNV.Enabled = true;
        }
    }
}
