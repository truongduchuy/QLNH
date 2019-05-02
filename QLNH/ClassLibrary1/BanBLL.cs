using QLNH_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BanBLL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        private static BanBLL instance;
        
        public static BanBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new BanBLL();
                }
                return instance;
            }
            set
            {
                BanBLL.instance = value;
            }
        }
        public List<Ban> ListBan(DataTable dt)
        {
            List<Ban> list = new List<Ban>();
            foreach (DataRow row in dt.Rows)
            {
                Ban ban = new Ban(row);
                list.Add(ban);
            }
            return list;
        }
        public List<Ban> Select_Ban()
        {
            //List<Ban> list = new List<Ban>();
            DataTable dt = thaotac.ExecuteQuery("Select_Ban");
            //foreach (DataRow row in dt.Rows)
            //{
            //    Ban ban = new Ban(row);
            //    list.Add(ban);
            //}
            //return list;
            return ListBan(dt);
        }
        public DataTable Search_Ban(string tenBan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenBan"; value[0] = tenBan;
            return thaotac.ExecuteQueryByMa("Search_Ban", name, value, 1);

        }
        public string Ban_SelectNewID()
        {
            DataTable dt = thaotac.ExecuteQuery("Ban_SelectNewID");
            return dt.Rows[0][0].ToString();
        }
        public int Count_BanByTinhTrang(bool tinhTrang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TinhTrang"; value[0] = tinhTrang;
            DataTable dt = thaotac.ExecuteQueryByMa("Count_BanByTinhTrang",name,value,1);
            int soBan =  int.Parse(dt.Rows[0][0].ToString());
            return soBan;
        }
        public int Insert_Ban(string maBan, string tenBan, bool tinhTrang)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaBan"; value[0] = maBan;
            name[1] = "@TenBan"; value[1] = tenBan;
            name[2] = "@TinhTrang"; value[2] = tinhTrang;
            return thaotac.ExecuteNonQuery("Insert_Ban", name, value, 3);
        }
        public int Update_Ban(string maBan, string tenBan, bool tinhTrang)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaBan"; value[0] = maBan;
            name[1] = "@TenBan"; value[1] = tenBan;
            name[2] = "@TinhTrang"; value[2] = tinhTrang;
            return thaotac.ExecuteNonQuery("Update_Ban", name, value, 3);
        }
        public int Delete_Ban(string maBan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan";
            value[0] = maBan;
            return thaotac.ExecuteNonQuery("Delete_Ban", name, value, 1);
        }
        public List<Ban> Select_BanByTinhTrang(bool tinhTrang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TinhTrang"; value[0] = tinhTrang;        
            DataTable dt = thaotac.ExecuteQueryByMa("Select_BanByTinhTrang", name, value, 1);          
            return ListBan(dt);
        }
        public int Update_TinhTrangBan(bool tinhTrang, string maBan)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@TinhTrang"; value[0] = tinhTrang;
            name[1] = "@MaBan"; value[1] = maBan;
            return thaotac.ExecuteNonQuery("Update_TinhTrangBan", name, value, 2);
        }


    }
}
