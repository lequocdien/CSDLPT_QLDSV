using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhapDAL
    {
        public static DataTable LoadPhanManh()
        {
            string chuoiketnoi = "Data Source=DESKTOP-EI49O32\\TRANQUANGCHAU;Initial Catalog=QLDSV;Integrated Security=True";
            Data.con.ConnectionString = chuoiketnoi;
            Data.con.Open();
            return DataProvider.TruyVanData("SELECT * FROM V_DS_PHANMANH");
        }

        public static int KiemTraTaiKhoan(string user, string password)
        {
            Data.mlogin = user;
            Data.password = password;
            if (DataProvider.KetNoi() == false) return 0;
            Data.mloginDN = Data.mlogin;
            Data.passwordDN = Data.password;
            string str = "EXEC SP_DANGNHAP'" + Data.mlogin + "'";
            Data.myReader = DataProvider.ExecSqlDataReader(str);
            if (Data.myReader == null) return 0;
            Data.myReader.Read();
            Data.username = Data.myReader.GetString(0);
            if (Convert.IsDBNull(Data.username))
            {
                return 1;//Tài khoản ko có quyền truy cập
            }
            else
            {
                Data.mHoten = Data.myReader.GetString(1);
                Data.mGroup = Data.myReader.GetString(2);
                Data.con.Close();
                return 2;//Đăng nhập thành công
            }
        }

        public static bool KetNoiKhoaMoi()
        {
            return DataProvider.KetNoi();
        }
    }
}
