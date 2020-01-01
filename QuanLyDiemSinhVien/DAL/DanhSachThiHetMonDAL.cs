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
    }
}
