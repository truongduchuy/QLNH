using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLNH_DAL
{
    public class ThaoTacCSDL
    {
        SqlConnection con;
        private void KetnoiCSDL()
        {
            con = new SqlConnection("Data Source=XE3H9M2TTKHOCLL\\SQLEXPRESS;Initial Catalog=QLNH2;Integrated Security=True");
            con.Open();
        }
        private void NgatKetNoi()
        {
            con.Close();
            con.Dispose();
        }
        public DataTable ExecuteQuery(string tensp)
        {
            KetnoiCSDL();
            SqlCommand command = new SqlCommand(tensp, con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public DataTable ExecuteQueryByMa(string tensp, string[] name, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand command = new SqlCommand(tensp, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public int ExecuteNonQuery(string tensp, string[] name, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand command = new SqlCommand(tensp, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            return command.ExecuteNonQuery();

        }
    }
}
