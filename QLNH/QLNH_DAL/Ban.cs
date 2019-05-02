using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAL
{
    public class Ban
    {
        
        public string MaBan { get; set; }
        public string TenBan { get; set; }
        public bool TinhTrang { get; set; }
        public Ban(DataRow row)
        {
            this.MaBan = row["MaBan"].ToString();
            this.TenBan = row["TenBan"].ToString();
            this.TinhTrang = Convert.ToBoolean(row["TinhTrang"]);
        }
        public Ban(string maBan, string tenBan, bool tinhtrang)
        {
            this.MaBan = maBan;
            this.TenBan = tenBan;
            this.TinhTrang = tinhtrang;
        }
        public override string ToString()
        {
            return TenBan;
        }
        
    }
}
