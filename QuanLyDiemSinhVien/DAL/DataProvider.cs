using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        private static SqlConnection con = null;

        public static SqlConnection KetNoiDB()
        {
            string connectionString = Common.Constant.CONNECTION_STRING;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public static DataTable TruyVanData(string chuoiTruyVan)
        {
            try
            {
                con = KetNoiDB();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(chuoiTruyVan, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                con.Close();
                return null;
            }
        }

        public static bool TruyVanNoneQuery(string chuoiTruyVan)
        {
            try
            {
                con = KetNoiDB();
                SqlCommand cmd = new SqlCommand(chuoiTruyVan, con);
                int res = cmd.ExecuteNonQuery();
                con.Close();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                con.Close();
                return false;
            }
        }

    }
}
