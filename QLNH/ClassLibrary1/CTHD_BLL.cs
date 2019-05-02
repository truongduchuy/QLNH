using QLNH_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CTHD_BLL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        private static CTHD_BLL instance;
        public static CTHD_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTHD_BLL();
                return CTHD_BLL.instance;
            }
            set
            {
                CTHD_BLL.instance = value;
            }
        }
        public List<CTHD> Select_CTHDByMaHD(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "MaHD"; value[0] = maHD;
            List<CTHD> list = new List<CTHD>();
            DataTable dt = thaotac.ExecuteQueryByMa("Select_CTHDByMaHD", name, value, 1);
            foreach (DataRow row in dt.Rows)
            {
                CTHD cthd = new CTHD(row);
                list.Add(cthd);
            }
            return list;
        }
        public int Insert_CTHDByMa(string maHD, string maHang, int sl)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaHang"; value[1] = maHang;
            name[2] = "@SL"; value[2] = sl;
            return thaotac.ExecuteNonQuery("Insert_CTHDByMa", name, value, 3);

        }
        public int Insert_CTHD(string maHD, string maHang, int sl)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaHang"; value[1] = maHang;
            name[2] = "@SL"; value[2] = sl;
            return thaotac.ExecuteNonQuery("Insert_CTHD", name, value, 3);
        }
        public int Update_CTHD(string maHD, string maHang, int sl)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaHang"; value[1] = maHang;
            name[2] = "@SL"; value[2] = sl;
            return thaotac.ExecuteNonQuery("Update_CTHD", name, value, 3);
        }
        public DataTable CTHD_HDBH(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = maHD;
            return thaotac.ExecuteQueryByMa("CTHD_HDBH", name, value, 1);
        }
        public DataTable Select_HoaDonBanByMa(string maBan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan";
            value[0] = maBan;           
            return  thaotac.ExecuteQueryByMa("Select_HoaDonBanByMa", name, value, 1);
        }
    }
}
