using ClassLibrary1;
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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtUser.Text = frmMain.TenDangNhap;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text == "" || txtNewPass.Text == "" || txtReNewPass.Text == "")
                {
                    if(txtPass.Text == "")
                    {
                        MessageBox.Show("Mật khẩu cũ không được để trống");
                    }
                    if (txtNewPass.Text == "")
                    {
                        MessageBox.Show("Mật khẩu mới không được để trống");
                    }
                    if (txtReNewPass.Text == "")
                    {
                        MessageBox.Show("Nhập lại mật khẩu không được để trống");
                    }

                }
                else
                {
                    if (NhanVienBLL.Instance.UpdatePass_NhanVien(txtUser.Text, txtNewPass.Text) > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void txtReNewPass_Leave(object sender, EventArgs e)
        {
            if(txtNewPass.Text != txtReNewPass.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác.");
                txtReNewPass.Text = "";
            }
            
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (NhanVienBLL.Instance.Login(txtUser.Text, txtPass.Text) <=0)
            {
                MessageBox.Show("Mật khẩu không chính xác.");
                txtReNewPass.Text = "";
            }
        }
    }
}
