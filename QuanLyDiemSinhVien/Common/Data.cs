using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class Data
    {
        // lúc load phân mảnh truyền chuỗi luôn khỏi khai báo biến. Do chỉ cần dùng 1 lần để lấy các svname ra thôi..sửa thì vào DangNhapDAL là được.ok ko?
        public static SqlConnection m_objConnection = new SqlConnection();
        public static String m_strServerName = ""; //server DN
        public static String m_strLogin = ""; //login DN
        public static String m_strPassword = ""; //pass DN

        public static String m_strLoginDN = ""; // biến giữ login DN
        public static String m_strPasswordDN = ""; //biến giữ pass DN

        public static String m_strMaGV = ""; //mã giảng viên
        public static String m_strGroup = ""; // nhóm
        public static String m_strHoten = ""; // họ tên

        public static int m_nKhoa = 0; // vị trí item trong combobox
        public static BindingSource bds_CNTT_VT = new BindingSource();
        public static string connstr;
    }
}
