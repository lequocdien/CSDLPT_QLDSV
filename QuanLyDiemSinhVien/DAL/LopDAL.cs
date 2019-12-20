using Common;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LopDAL
    {
        public static DataTable LoadLop()
        {
            if(DataProvider.ConnectDatabase())
            {
                string str = "select MALOP,TENLOP,MAKH from LOP";
                return DataProvider.ExecSQLQueryDataTable(str);
            }
            return null;
        }

        public static bool AddLop(LopDTO lop)
        {
            string str = "insert into LOP(MALOP,TENLOP,MAKH) values ('"+lop.MALOP+ "',N'" + lop.TENLOP + "','" + lop.MAKH + "')";
            return DataProvider.ExecSQLQuery(str);
        }

        public static bool DeleteLop(string malop)
        {
            string str = "delete from LOP where MALOP = '" + malop + "'";
            return DataProvider.ExecSQLQuery(str);
        }

        public static bool UpdateLop(LopDTO lop)
        {
            string str = "update LOP set TENLOP = N'" + lop.TENLOP + "', MAKH = '" + lop.MAKH + "' where MALOP = '" + lop.MALOP + "'";
            return DataProvider.ExecSQLQuery(str);
        }
    }
}
