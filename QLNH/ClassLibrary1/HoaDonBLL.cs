using QLNH_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HoaDonBLL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        private static HoaDonBLL instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonBLL();
                return HoaDonBLL.instance;
            }
            set
            {
                HoaDonBLL.instance = value;
            }
        }
        public DataTable Select_HoaDon()
        {
            return thaotac.ExecuteQuery("Select_HoaDon");
        }
        public DataTable Search_HoaDonByNgayLap(DateTime ngayHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@NgayHD"; value[0] = ngayHD;
            
            return thaotac.ExecuteQueryByMa("Search_HoaDonByNgayLap", name,value,1);
        }
        public int Insert_HD(string maHD, DateTime ngayHD, bool tinhTrang, string maBan, string tenDangNhap)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@NgayHD"; value[1] = ngayHD;
            name[2] = "@TinhTrang"; value[2] = tinhTrang;
            name[3] = "@MaBan"; value[3] = maBan;
            name[4] = "@TenDangNhap"; value[4] = tenDangNhap;
            return thaotac.ExecuteNonQuery("Insert_HD", name, value, 5);
        }
        public int Update_HoaDon(string maHD, DateTime ngayHD, bool tinhTrang, string maBan, string tenDangNhap)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@NgayHD"; value[1] = ngayHD;
            name[2] = "@TinhTrang"; value[2] = tinhTrang;
            name[3] = "@MaBan"; value[3] = maBan;
            name[4] = "@TenDangNhap"; value[4] = tenDangNhap;
            return thaotac.ExecuteNonQuery("Update_HoaDon", name, value, 5);
        }
        public int Delete_HoaDon(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = maHD;
            return thaotac.ExecuteNonQuery("Delete_HoaDon", name, value, 1);
        }
        public string Select_HoaDonChuaThanhToanByMaBan(string maBan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan";
            value[0] = maBan;
            DataTable dt = thaotac.ExecuteQueryByMa("Select_HoaDonChuaThanhToanByMaBan", name, value, 1);
            if(dt.Rows.Count > 0)
            {
                HoaDon hd = new HoaDon(dt.Rows[0]);
                return hd.MaHD;
            }
            return "";
        }
        public string HoaDon_SelectNewID()
        {

            DataTable dt = thaotac.ExecuteQuery("HoaDon_SelectNewID");
            return dt.Rows[0][0].ToString();
        }
        public string Get_MaxMaHD()
        {
            
            DataTable dt = thaotac.ExecuteQuery("Get_MaxMaHD");
            return dt.Rows[0]["MaHD"].ToString();
        }
        public int Insert_HoaDon(string maBan, string TenDangNhap)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBan"; value[0] = maBan;
            name[1] = "@TenDangNhap"; value[1] = TenDangNhap;
            return thaotac.ExecuteNonQuery("Insert_HoaDon", name, value, 2);
        }
        public int Insert_HoaDonByMaHD(string maHD, string maBan, string TenDangNhap)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaBan"; value[1] = maBan;
            name[2] = "@TenDangNhap"; value[2] = TenDangNhap;
            return thaotac.ExecuteNonQuery("Insert_HoaDonByMaHD", name, value, 3);
        }
        public int Delete_HoaDonChuaThanhToanByMaHD(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = maHD;
            
            return thaotac.ExecuteNonQuery("Delete_HoaDonChuaThanhToanByHD", name, value, 1);
        }
        public int Update_HoaDonByMaBanAndMaHD(string maBan, string maHD)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBan"; value[0] = maBan;
            name[1] = "@maHD"; value[1] = maHD;
            return thaotac.ExecuteNonQuery("Update_HoaDonByMaBanAndMaHD", name, value, 2);
        }
        public int Update_TinhTrangHDByMaHD(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = maHD;

            return thaotac.ExecuteNonQuery("Update_TinhTrangHDByMaHD", name, value, 1);
        }
        public DataTable ThongKeDoanhThu(DateTime ngayBD, DateTime ngayKT)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@NgayBatDau"; value[0] = ngayBD;
            name[1] = "@NgayKetThuc"; value[1] = ngayKT;
            return thaotac.ExecuteQueryByMa("ThongKeDoanhThu", name, value, 2);
        }
    }
}
