using QLNH_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NhanVienBLL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        private static NhanVienBLL instance;
        public static NhanVienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBLL();
                return NhanVienBLL.instance;
            }
            set { NhanVienBLL.instance = value; }
        }
        public int Login(string tenDangNhap, string matKhau)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "TenDangNhap"; value[0] = tenDangNhap;
            name[1] = "MatKhau"; value[1] = matKhau;
            DataTable dt =  thaotac.ExecuteQueryByMa("Login", name, value, 2);
            if(dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            return -1;
        }
        public string GetQuyenByTenDangNhap(string tenDangNhap)
        {
            name = new string[1];
            value = new object[1];
            DataTable dt = Select_NhanVienByTenDN(tenDangNhap);
            return dt.Rows[0]["Quyen"].ToString();
        }
        public DataTable Select_NhanVien()
        {
            return thaotac.ExecuteQuery("Select_NhanVien");
        }
        public DataTable Select_NhanVienByTenDN(string tenDangNhap)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenDangNhap"; value[0] = tenDangNhap;
            return thaotac.ExecuteQueryByMa("Select_NhanVienByTenDN", name, value, 1);
        }
        public DataTable Search_NhanVienByTenDN(string tenDangNhap)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenDangNhap"; value[0] = tenDangNhap;
            return thaotac.ExecuteQueryByMa("Search_NhanVienByTenDN", name, value, 1);
        }
        public int Insert_NhanVien(string tenDangNhap, string tenNV, string matKhau, string quyen, byte[] img)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@TenDangNhap"; value[0] = tenDangNhap;
            name[1] = "@TenNhanVien"; value[1] = tenNV;
            name[2] = "@MatKhau"; value[2] = matKhau;
            name[3] = "@Quyen"; value[3] = quyen;
            name[4] = "@Anh"; value[4] = img;
            return thaotac.ExecuteNonQuery("Insert_NhanVien", name, value, 5);
        }
        public int Update_NhanVien(string tenDangNhap, string tenNV, string matKhau, string quyen, byte[] img)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@TenDangNhap"; value[0] = tenDangNhap;
            name[1] = "@TenNhanVien"; value[1] = tenNV;
            name[2] = "@MatKhau"; value[2] = matKhau;
            name[3] = "@Quyen"; value[3] = quyen;
            name[4] = "@Anh"; value[4] = img;
            return thaotac.ExecuteNonQuery("Update_NhanVien", name, value, 5);
        }
        public int Update_NhanVienNoImg(string tenDangNhap, string tenNV, string matKhau, string quyen)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@TenDangNhap"; value[0] = tenDangNhap;
            name[1] = "@TenNhanVien"; value[1] = tenNV;
            name[2] = "@MatKhau"; value[2] = matKhau;
            name[3] = "@Quyen"; value[3] = quyen;
            
            return thaotac.ExecuteNonQuery("Update_NhanVienNoImg", name, value, 4);
        }
        public int Delete_NhanVien(string tenDangNhap)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenDangNhap"; value[0] = tenDangNhap;
            return thaotac.ExecuteNonQuery("Delete_NhanVien", name, value, 1);
        }
        public int UpdatePass_NhanVien(string tenDangNhap, string matkhau)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@TenDangNhap"; value[0] = tenDangNhap;
            name[1] = "@MatKhau"; value[1] = matkhau;
            return thaotac.ExecuteNonQuery("UpdatePass_NhanVien", name, value, 2);
        }
        
    }
}
