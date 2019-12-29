using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocPhiDAL
    {
        public static SqlDataReader LoadInfoSinhVien(string x_strMaSinhVien)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_LoadInfoSinhVien '{0}'", x_strMaSinhVien));
            }
            return null;
        }

        public static SqlDataReader LoadHocPhi(string x_strMaSinhVien)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_LoadHocPhi '{0}'", x_strMaSinhVien));
            }
            return null;
        }
    }
}
