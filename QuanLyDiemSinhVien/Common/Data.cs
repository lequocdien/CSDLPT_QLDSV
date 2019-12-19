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
        #region Constants
        public const string  DATABASE_NAME = "CSDLPT_QLDSV";

        public const string SERVER_NAME = "DIEN-PC";
        public const string USER_ID = "sa";
        public const string PASSWORD = "0000";

        public const string REMOTE_LOGIN = "HTKN";
        public const string REMOTE_PASSWORD = "1234";
        #endregion

        #region Fields
        public static SqlConnection m_objCon = new SqlConnection();
        public static String m_strServerNameDN;
        public static String m_strUserIDDN;
        public static String m_strPasswordDN;

        public static SqlDataReader m_objDataReader;
        public static String m_strGroup;
        public static String m_strHoten;
        public static int m_nKhoa;
        #endregion
    }
}
