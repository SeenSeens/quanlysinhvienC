using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Demo.Controller;
using Demo.View;

namespace Demo.Model
{
    class mXuly
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static string lenh = @"Data Source=DESKTOP-G55OH0B;Initial Catalog=QLSV;Integrated Security=True";
        public static DataTable TaoBang(string sql)
        {
            conn = new SqlConnection(lenh);
            conn.Open();
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecuteNonQuery(string sql)
        {
            int re = 0;
            try
            {
                conn = new SqlConnection(lenh);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                re = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
            return re;
        }
    }
}
