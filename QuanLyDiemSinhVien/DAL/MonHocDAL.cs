using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonHocDAL
    {
        public static DataTable LoadMonHoc()
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLQueryDataTable("SELECT * FROM MONHOC");
            }
            return null;
        }

        public static bool InsertMonHoc(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLQuery(string.Format("INSERT INTO MONHOC(MAMH, TENMH) VALUES('{0}', N'{1}')", x_strMaMonHoc, x_strTenMonHoc));
            }
            return false;
        }

        public static bool UpdateMonHoc(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLQuery(string.Format("UPDATE MONHOC SET TENMH = N'{0}' WHERE MAMH = '{1}'", x_strTenMonHoc, x_strMaMonHoc));
            }
            return false;
        }

        public static bool DeleteMonHoc(string x_strMaMonHoc)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLQuery(string.Format("DELETE FROM MONHOC WHERE MAMH = '{0}'", x_strMaMonHoc));
            }
            return false;
        }
    }
}
