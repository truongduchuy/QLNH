using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAL
{
    public class CTHD
    {
        public string MaHD { get; set; }
        public string MaHang { get; set; }
        public int SL { get; set; }
        public CTHD(string maHD, string maHang, int sl)
        {
            MaHD = maHD;
            MaHang = maHang;
            SL = sl;
        }
        public CTHD(DataRow row)
        {
            MaHD = row["MaHD"].ToString();
            MaHang = row["MaHang"].ToString();
            SL = (int)row["SL"];
        }
    }
}
