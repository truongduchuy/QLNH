using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAL
{
    public class LoaiHang
    {
        public string MaLH { get; set; }
        public string TenLH { get; set; }
        public LoaiHang(string maLH, string tenLH)
        {
            MaLH = maLH;
            TenLH = tenLH;
        }
        public LoaiHang(DataRow row)
        {
            MaLH = row["MaLH"].ToString();
            TenLH = row["TenLH"].ToString();
        }
        public override string ToString()
        {
            return TenLH;
        }
    }
}
