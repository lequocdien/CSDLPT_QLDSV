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
        // lúc load phân mảnh truyền chuỗi luôn khỏi khai báo biến. Do chỉ cần dùng 1 lần để lấy các svname ra thôi..sửa thì vào DangNhapDAL là được.ok ko?
        public static SqlConnection Con = new SqlConnection();
        public static String m_strServerName = ""; //server DN
        public static String m_strLogin = ""; //login DN
        public static String m_strPassword = ""; //pass DN

        public static String Database = "QLDSV";
        public static String Remote_Login = "HTKN";
        public static String Remote_Password = "12345";
        public static String m_strLoginDN = ""; // biến giữ login DN
        public static String m_strPasswordDN = ""; //biến giữ pass DN

        public static String User_ID = ""; //mã giảng viên
        public static String m_strGroup = ""; // nhóm
        public static String m_strHoten = ""; // họ tên

        public static int m_nKhoa = 0; // vị trí item trong combobox
    }
}
