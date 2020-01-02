using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhSachThiHetMonDAL
    {
        public static SqlDataReader LoadDanhSachThiHetMon(string x_strMaLop, string x_strMaMonHoc, int x_nLanThi)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_DanhSachThiHetMon '{0}', '{1}', {2}", x_strMaLop, x_strMaMonHoc, x_nLanThi));
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

        public static SqlDataReader GetTenMonHoc(string x_strMaMonHoc)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT TENMH FROM MONHOC WHERE MAMH = '{0}'", x_strMaMonHoc));
            }
            return null;
        }
    }
}
