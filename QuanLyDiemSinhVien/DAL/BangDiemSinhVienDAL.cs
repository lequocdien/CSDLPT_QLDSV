using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BangDiemSinhVienDAL
    {
        public static SqlDataReader LoadPhanManh()
        {
            try
            {
                Data.m_objConnection.Close();
                string strConnectionString = "Data Source=" + Constant.SERVER_NAME + ";Initial Catalog=" + Constant.DATABASE_NAME + ";Integrated Security=True";
                Data.m_objConnection.ConnectionString = strConnectionString;
                Data.m_objConnection.Open();

                return DataProvider.ExecSQLDataReader("SELECT * FROM V_DS_PHANMANH");
            }
            catch
            {
                return null;
            }
        }

        public static bool ChangeServer()
        {
            if (DataProvider.ConnectDatabase())
            {
                return true;
            }
            return false;
        }

        public static SqlDataReader LoadLop()
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT MALOP, TENLOP FROM LOP"));
            }
            return null;
        }

        public static SqlDataReader LoadSinhVien()
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT MASV FROM SINHVIEN"));
            }
            return null;
        }

        public static SqlDataReader LoadPhieuDiem(string x_strMaSV)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_PhieuDiem '{0}'", x_strMaSV));
            }
            return null;
        }

        public static SqlDataReader GetHoTen(string x_strMaSV)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT HOTEN = HO + ' ' + TEN FROM SINHVIEN WHERE MASV = '{0}'", x_strMaSV));
            }
            return null;
        }

        public static SqlDataReader GetMaLop(string x_strMaSV)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT MALOP FROM SINHVIEN WHERE MASV = '{0}'", x_strMaSV));
            }
            return null;
        }
    }
}
