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
        /// <param name="x_strServerName"></param>
        /// <param name="x_strUserID"></param>
        /// <param name="x_strPassword"></param>
        /// <returns></returns>
        public static bool ConnectDatabase(string x_strServerName, string x_strUserID, string x_strPassword)
        {
            if (Data.m_objCon != null && Data.m_objCon.State == ConnectionState.Open)
            {
                Data.m_objCon.Close();
            }
            try
            {
                Data.m_strServerNameDN = x_strServerName;
                Data.m_strUserIDDN = x_strUserID;
                Data.m_strPasswordDN = x_strPassword;

                string strConnectionString = "Data Source=" + Data.m_strServerNameDN + ";Initial Catalog=" +
                       Data.DATABASE_NAME + ";User ID=" + Data.m_strUserIDDN + ";password=" + Data.m_strPasswordDN;
                Data.m_objCon.ConnectionString = strConnectionString;
                Data.m_objCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + ex.Message, "", MessageBoxButtons.OK);
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
            if(Data.m_objCon.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter objDap = new SqlDataAdapter(x_strQueryString, Data.m_objCon);
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
            if (Data.m_objCon.State == ConnectionState.Open)
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandText = x_strQueryString;
                objCommand.CommandType = CommandType.Text;
                objCommand.Connection = Data.m_objCon;
                int nRes = objCommand.ExecuteNonQuery();
                if(nRes == 0)
                {
                    return false;
                }
                return true;
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
            SqlCommand objSQLCommand = new SqlCommand(x_strQueryString, Data.m_objCon);
            objSQLCommand.CommandType = CommandType.Text;
            if (Data.m_objCon.State == ConnectionState.Closed)
            {
                Data.m_objCon.Open();
            }
            try
            {
                objDataReader = objSQLCommand.ExecuteReader(); 
                return objDataReader;
            }
            catch (SqlException ex)
            {
                Data.m_objCon.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
