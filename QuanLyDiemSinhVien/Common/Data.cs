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
        public static string DATABASE_NAME = "CSDLPT_QLDSV";

        public static string SERVER_NAME = "DIEN-PC";
        public static string USER_ID = "sa";
        public static string PASSWORD = "0000";

        public static string SERVER_NAME_1 = "DIEN-PC\\SERVER1";
        public static string USER_ID_1 = "sa";
        public static string PASSWORD_1 = "0000";

        public static string SERVER_NAME_2 = "DIEN-PC\\SERVER2";
        public static string USER_ID_2 = "sa";
        public static string PASSWORD_2 = "0000";

        public static string SERVER_NAME_3 = "DIEN-PC\\SERVER3";
        public static string USER_ID_3 = "sa";
        public static string PASSWORD_3 = "0000";

        public static string REMOTE_LOGIN = "HTKN";
        public static string REMOTE_PASSWORD = "1234";
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
