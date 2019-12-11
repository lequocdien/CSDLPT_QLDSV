using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DataProvider
    {
        //  private static SqlConnection con = null;

        public static SqlConnection KetNoiDB()
        {
            string connectionString = Common.Constant.CONNECTION_STRING;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public static bool KetNoi()
        {
            if (Data.con != null && Data.con.State == ConnectionState.Open)
                Data.con.Close();
            try
            {
                Data.connstr = "Data Source=" + Data.servername + ";Initial Catalog=" +
                      Data.database + ";User ID=" +
                      Data.mlogin + ";password=" + Data.password;
                Data.con.ConnectionString = Data.connstr;
                Data.con.Open();
                return true;
            }

            catch (Exception e)
            {
               // MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Data.con);
            sqlcmd.CommandType = CommandType.Text;
            if (Data.con.State == ConnectionState.Closed) Data.con.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Data.con.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable TruyVanData(string chuoiTruyVan)
        {
            try
            {
                // con = KetNoiDB();
                if (Data.con.State == ConnectionState.Closed) Data.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(chuoiTruyVan, Data.con);
                da.Fill(dt);
                Data.con.Close();
                return dt;
            }
            catch
            {
                Data.con.Close();
                return null;
            }
        }

        public static bool TruyVanNoneQuery(string chuoiTruyVan)
        {
            try
            {
                //   con = KetNoiDB();
                if (Data.con.State == ConnectionState.Closed) Data.con.Open();
                SqlCommand cmd = new SqlCommand(chuoiTruyVan, Data.con);
                int res = cmd.ExecuteNonQuery();
                Data.con.Close();
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
                Data.con.Close();
                return false;
            }
        }

    }
}
