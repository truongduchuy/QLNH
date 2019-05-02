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
    public partial class frmLogin : Form
    {
        public static string TenDangNhap;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (NhanVienBLL.Instance.Login(txtUser.Text, txtPass.Text) > 0)
            {
                TenDangNhap = txtUser.Text;
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
