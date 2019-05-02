using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAL
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public DateTime NgayHD { get; set; }
        public bool TinhTrang { get; set; }
        public string MaBan { get; set; }
        public string TenDangNhap { get; set; }
        public HoaDon(string maHD, DateTime ngayHD, bool tinhTrang, string maBan, string tenDangNhap)
        {
            MaHD = maHD;
            NgayHD = ngayHD;
            TinhTrang = tinhTrang;
            MaBan = maBan;
            TenDangNhap = tenDangNhap;
        }
        public HoaDon(DataRow row)
        {
            MaHD = row["MaHD"].ToString();
            NgayHD = Convert.ToDateTime(row["NgayHD"]);
            TinhTrang = Convert.ToBoolean(row["TinhTrang"]);
            MaBan = row["MaBan"].ToString();
            TenDangNhap = row["TenDangNhap"].ToString();
        }
    }
}
