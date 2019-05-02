using QLNH_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LoaiHangBLL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        private static LoaiHangBLL instance;
        public static LoaiHangBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiHangBLL();
                return instance;
            }
            set
            {
                LoaiHangBLL.instance = value;
            }
        }
        public List<LoaiHang> SetList(DataTable dt)
        {
            List<LoaiHang> list = new List<LoaiHang>();
            foreach (DataRow row in dt.Rows)
            {
                LoaiHang lh = new LoaiHang(row);
                list.Add(lh);
            }
            return list;
        }
        public List<LoaiHang> Select_LoaiHang()
        {
            
            DataTable dt = thaotac.ExecuteQuery("Select_LoaiHang");

            return SetList(dt);
        }
        public List<LoaiHang> Search_LoaiHang(string tenLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenLH"; value[0] = tenLH;
            
            DataTable dt = thaotac.ExecuteQueryByMa("Search_LoaiHang", name, value, 1);
            return SetList(dt);
        }
        public int Insert_LoaiHang(string tenLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenLH"; value[0] = tenLH;
            return thaotac.ExecuteNonQuery("Insert_LoaiHang", name, value, 1);
        }
        public int Update_LoaiHang(string maLH, string tenLH)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaLH"; value[0] = maLH;
            name[1] = "@TenLH"; value[1] = tenLH;
            return thaotac.ExecuteNonQuery("Update_LoaiHang", name, value, 2);
        }
        public int Delete_LoaiHang(string maLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLH"; value[0] = maLH;
            return thaotac.ExecuteNonQuery("Delete_LoaiHang", name, value, 1);
        }
    }
}
