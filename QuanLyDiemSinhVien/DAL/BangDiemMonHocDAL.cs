using Common;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BangDiemMonHocDAL
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

        public static SqlDataReader LoadMonHoc()
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT MAMH, TENMH FROM MONHOC"));
            }
            return null;
        }

        public static SqlDataReader LoadLanThi(string x_strMaMonHoc, string x_strMaLop)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_SoLanThi '{0}', '{1}'", x_strMaMonHoc, x_strMaLop));
            }
            return null;
        }

        public static SqlDataReader LoadBangDiemMonHoc(string x_strMaLop, string x_strMaMH, int x_nLanThi)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_BangDiemMonHoc '{0}', '{1}', {2}", x_strMaLop, x_strMaMH, x_nLanThi));
            }
            return null;
        }

        public static SqlDataReader GetTenMonHoc(string x_strMaMH)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT TENMH FROM MONHOC WHERE MAMH = '{0}'", x_strMaMH));
            }
            return null;
        }

        public static SqlDataReader GetTenLop(string x_strMaLop)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT TENLOP FROM LOP WHERE MALOP = '{0}'", x_strMaLop));
            }
            return null;
        }
    }
}
