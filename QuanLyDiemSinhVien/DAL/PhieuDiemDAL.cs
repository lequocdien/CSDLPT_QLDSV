using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDiemDAL
    {
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
