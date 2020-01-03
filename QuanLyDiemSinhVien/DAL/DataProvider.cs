using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        /// <summary>
        /// Kết nối đên cơ sở dữ liệu
        /// </summary>
        /// <returns></returns>
        //sv chạy tới đâu gán tới đó luôn..rồi gọi hàm connect thôi..do khai báo biến tổng rồi khỏi truyền..OK ko? 
        public static bool ConnectDatabase()
        {
            if (Data.m_objConnection != null && Data.m_objConnection.State == ConnectionState.Open)
            {
                Data.m_objConnection.Close();
            }
            try
            {
                string strConnectionString = "Data Source=" + Data.m_strServerName + ";Initial Catalog=" +
                       Constant.DATABASE_NAME + ";User ID=" + Data.m_strLogin + ";password=" + Data.m_strPassword;
                Data.connstr = strConnectionString;
                Data.m_objConnection.ConnectionString = strConnectionString;
                Data.m_objConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + ex.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        /// <summary>
        /// Đọc dữ liệu từ database và trả về DataTables (Thực hiện SELECT)
        /// </summary>
        /// <param name="x_strQueryString"></param>
        /// <returns></returns>
        public static DataTable ExecSQLQueryDataTable(string x_strQueryString)
        {
            if(Data.m_objConnection.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter objDap = new SqlDataAdapter(x_strQueryString, Data.m_objConnection);
                objDap.Fill(dt);
                return dt;
            }
            return null;
        }

        /// <summary>
        /// Thực hiện UPDATE, INSERT, DELETE
        /// </summary>
        /// <param name="x_strQueryString"></param>
        /// <returns></returns>
        public static bool ExecSQLQuery(string x_strQueryString)
        {
            if (Data.m_objConnection.State == ConnectionState.Open)
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandText = x_strQueryString;
                objCommand.CommandType = CommandType.Text;
                objCommand.Connection = Data.m_objConnection;
                try
                {
                    int nRes = objCommand.ExecuteNonQuery();
                    if (nRes == 0)
                    {
                        return false;
                    }
                    return true;
                }
                catch
                {

                }
            }
            return false;
        }

        /// <summary>
        /// Thực hiện Store Proceduced
        /// </summary>
        /// <param name="x_strQueryString"></param>
        /// <returns></returns>
        public static SqlDataReader ExecSQLDataReader(string x_strQueryString)
        {
            SqlDataReader objDataReader;
            SqlCommand objSQLCommand = new SqlCommand(x_strQueryString, Data.m_objConnection);
            objSQLCommand.CommandType = CommandType.Text;
            if (Data.m_objConnection.State == ConnectionState.Closed)
            {
                Data.m_objConnection.Open();
            }
            try
            {
                objDataReader = objSQLCommand.ExecuteReader(); 
                return objDataReader;
            }
            catch
            {
                Data.m_objConnection.Close();
            }
            return null;
        }

    }
}
