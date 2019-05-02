using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAL
{
    public class HangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int DonGia { get; set; }
        public int SLCon { get; set; }
        public string MaLH { get; set; }
        public HangHoa(string mahang, string tenhang, int dongia, int slcon, string maLH)
        {
            MaHang = mahang;
            TenHang = tenhang;
            DonGia = dongia;
            SLCon = slcon;
            MaLH = maLH;
        }
        public HangHoa(DataRow row)
        {
            MaHang = row["MaHang"].ToString();
            TenHang = row["TenHang"].ToString();
            DonGia = (int)row["DonGia"];
            SLCon = (int)row["SLCon"];
            MaLH = row["MaLH"].ToString();
        }
        public override string ToString()
        {
            return TenHang;
        }
    }
}
