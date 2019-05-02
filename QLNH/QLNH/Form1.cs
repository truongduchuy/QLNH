using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=XE3H9M2TTKHOCLL\\SQLEXPRESS;Initial Catalog=QLNH2;Integrated Security=True");
        SqlCommand command;
        string imgLoc = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picEmp.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "insert into NhanVien(TenDangNhap, TenNhanVien, MatKhau, Anh) values ('" + txtTenDangNhap.Text + "', '"+txtTenNV.Text+ "', '" + txtPass.Text + "',@img)";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                command.Parameters.Add(new SqlParameter("@img", img));
                int x = command.ExecuteNonQuery();
                MessageBox.Show(x.ToString() + " record(s) saved.");
                txtTenDangNhap.Text = "";
                txtTenNV.Text = "";
                txtPass.Text = "";
                picEmp.Image = null;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from NhanVien where TenDangNhap = '"+txtTenDangNhap.Text+"'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                {
                    txtTenDangNhap.Text = reader[0].ToString();
                    txtTenNV.Text = reader[1].ToString();
                    txtPass.Text = reader[2].ToString();
                    byte[] img = (byte[])(reader[4]);
                    if (img == null)
                        picEmp.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picEmp.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("This is does not exist");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
