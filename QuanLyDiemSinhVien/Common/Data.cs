using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Data
    {
        public static SqlConnection m_objCon = new SqlConnection();
        public static String m_strConnectionString = string.Empty;
        public static String m_strDatabaseName = "CSDLPT_QLDSV";
        public static String m_strServerName = "";
        public static String m_strUserID = "";
        public static String m_strPassword = "";

        public static SqlDataReader myReader;
        public static String mlogin = "";

        public static String remotelogin = "HTKN";
        public static String remotepassword = "12345";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mKhoa = 0;
    }
}
