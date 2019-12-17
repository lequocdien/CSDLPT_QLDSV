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
            if (DataProvider.ConnectDatabase(ConfigurationManager.AppSettings["ServerName"], ConfigurationManager.AppSettings["UserID"], ConfigurationManager.AppSettings["Password"]))
            {
                return DataProvider.ExecSQLQueryDataTable("SELECT * FROM MONHOC");
            }
            return null;
        }
    }
}
