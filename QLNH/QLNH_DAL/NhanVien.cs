using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAL
{
    public class NhanVien
    {
        public string TenDangNhap { get; set; }
        public string TenNhanVien { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }
        public NhanVien(string tenDangNhap, string tenNhanVien, string matKhau, string quyen)
        {
            TenDangNhap = tenDangNhap;
            TenNhanVien = tenNhanVien;
            MatKhau = matKhau;
            Quyen = quyen;

        }
        public NhanVien(DataRow row)
        {
            TenDangNhap = row["TenDangNhap"].ToString();
            TenNhanVien = row["TenNhanVien"].ToString();
            MatKhau = row["MatKhau"].ToString();
            Quyen = row["Quyen"].ToString();

        }
    }
}
