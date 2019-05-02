using QLNH_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HangHoaBLL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        private static HangHoaBLL instance;
        public static HangHoaBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangHoaBLL();
                return instance;
            }
            set
            {
                HangHoaBLL.instance = value;
            }
        }
        public string HangHoa_SelectNewID()
        {
            DataTable dt = thaotac.ExecuteQuery("HangHoa_SelectNewID");
            return dt.Rows[0][0].ToString();
        }
        public List<HangHoa> Select_HangHoaByMaLH(string maLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLH";
            value[0] = maLH;
            List<HangHoa> list = new List<HangHoa>();
            DataTable dt = thaotac.ExecuteQueryByMa("Select_HangHoaByMaLH",name,value,1);
            foreach (DataRow row in dt.Rows)
            {
                HangHoa hh = new HangHoa(row);
                list.Add(hh);
            }
            return list;
        }
        public DataTable Select_HangHoa()
        {
            return thaotac.ExecuteQuery("Select_HangHoa");
        }
        public DataTable Search_HangHoa(string tenHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenHang"; value[0] = tenHang;
            return thaotac.ExecuteQueryByMa("Search_HangHoa",name, value, 1);
        }
        public int Insert_HangHoa(string maHang, string tenHang, int DonGia, int slCon, string maLH)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaHang"; value[0] = maHang;
            name[1] = "@TenHang"; value[1] = tenHang;
            name[2] = "@DonGia"; value[2] = DonGia;
            name[3] = "@SLCon"; value[3] = slCon;
            name[4] = "@MaLH"; value[4] = maLH;
            return thaotac.ExecuteNonQuery("Insert_HangHoa", name, value, 5);
        }
        public int Update_HangHoa(string maHang, string tenHang, int DonGia, int slCon, string maLH)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaHang"; value[0] = maHang;
            name[1] = "@TenHang"; value[1] = tenHang;
            name[2] = "@DonGia"; value[2] = DonGia;
            name[3] = "@SLCon"; value[3] = slCon;
            name[4] = "@MaLH"; value[4] = maLH;
            return thaotac.ExecuteNonQuery("Update_HangHoa", name, value, 5);
        }
        public int Delete_HangHoa(string maHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang"; value[0] = maHang;
            
            return thaotac.ExecuteNonQuery("Delete_HangHoa", name, value, 1);
        }
    }
}
