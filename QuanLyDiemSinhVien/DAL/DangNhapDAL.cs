using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhapDAL
    {
        public static DataTable LoadPhanManh()
        {
            Data.Con.Close();
            string chuoiketnoi = "Data Source=DESKTOP-EI49O32\\TRANQUANGCHAU;Initial Catalog=QLDSV;Integrated Security=True";
            Data.Con.ConnectionString = chuoiketnoi;
            Data.Con.Open();
            return DataProvider.ExecSQLQueryDataTable("SELECT * FROM V_DS_PHANMANH");
        }

        public static int KiemTraTaiKhoan(string user, string password)
        {
            Data.m_strLogin = user;
            Data.m_strPassword = password;
            if (DataProvider.ConnectDatabase() == false) return 0;
            Data.m_strLoginDN = Data.m_strLogin;
            Data.m_strPasswordDN = Data.m_strPassword;
            string str = "EXEC SP_DANGNHAP'" + Data.m_strLogin + "'";
            SqlDataReader myReader;
            myReader = DataProvider.ExecSQLDataReader(str);
            if (myReader == null) return 0;
            myReader.Read();
            Data.User_ID = myReader.GetString(0);
            if (Convert.IsDBNull(Data.User_ID))
            {
                return 1;//Tài khoản ko có quyền truy cập
            }
            else
            {
                Data.m_strHoten = myReader.GetString(1);
                Data.m_strGroup = myReader.GetString(2);
                Data.Con.Close();
                return 2;//Đăng nhập thành công
            }
        }

        public static bool KetNoiKhoaMoi()
        {
            return DataProvider.ConnectDatabase();
        }
    }
}
