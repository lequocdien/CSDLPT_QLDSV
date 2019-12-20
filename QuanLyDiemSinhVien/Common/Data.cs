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
        public static SqlConnection con = new SqlConnection();
        public static String servername = ""; //server DN
        public static String username = ""; //mã giảng viên
        public static String mlogin = ""; //login DN
        public static String password = ""; //pass DN

        public static String database = "QLDSV";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "12345";
        public static String mloginDN = ""; // biến giữ login DN
        public static String passwordDN = ""; //biến giữ pass DN
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mKhoa = 0; // vị trí item trong combobox
    }
}
