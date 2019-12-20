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
            //TODO: Hien tai dang ket noi den server goc => sua lai ket noi den ServerNameDN khi dang nhap
            if (DataProvider.ConnectDatabase(/*Common.Data.SERVER_NAME, Common.Data.USER_ID, Common.Data.PASSWORD*/))
            {
                return DataProvider.ExecSQLQueryDataTable("SELECT * FROM MONHOC");
            }
            return null;
        }

        public static bool InsertMonHoc(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            //TODO: Hien tai dang ket noi den server goc => sua lai ket noi den ServerNameDN khi dang nhap
            if (DataProvider.ConnectDatabase(/*Common.Data.SERVER_NAME, Common.Data.USER_ID, Common.Data.PASSWORD*/))
            {
                return DataProvider.ExecSQLQuery(string.Format("INSERT INTO MONHOC(MAMH, TENMH) VALUES('{0}', '{1}')", x_strMaMonHoc, x_strTenMonHoc));
            }
            return false;
        }
    }
}
