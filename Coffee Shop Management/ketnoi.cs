using System;
using System.Data;
using System.Data.SqlClient;

namespace Coffee_Shop_Management
{
    public class ketnoi
    {
        public static string strKetNoi = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CoffeeShopManagement;Integrated Security=True";

        public static DataTable LayDuLieu(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static int ThucThiLenh(string query, SqlParameter[] parameters = null)
        {
            int sodong = 0;
            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    sodong = cmd.ExecuteNonQuery();
                }
            }
            return sodong;
        }

        public static object LayGiaTriDon(string query, SqlParameter[] parameters = null)
        {
            object ketqua = null;
            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    ketqua = cmd.ExecuteScalar();
                }
            }
            return ketqua;
        }
    }
}