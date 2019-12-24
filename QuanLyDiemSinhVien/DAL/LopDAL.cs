using Common;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LopDAL
    {
        public static DataTable LoadKhoa()
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "select MAKH, TENKH from KHOA";
                return DataProvider.ExecSQLQueryDataTable(str);
            }
            return null;
        }
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
            if (DataProvider.ConnectDatabase())
            {
                string str = "insert into LOP(MALOP,TENLOP,MAKH) values ('" + lop.MALOP + "',N'" + lop.TENLOP + "','" + lop.MAKH + "')";
                return DataProvider.ExecSQLQuery(str);
            }
            return false;
        }

        public static bool DeleteLop(string malop)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "delete from LOP where MALOP = '" + malop + "'";
                return DataProvider.ExecSQLQuery(str);
            }
            return false;
        }

        public static bool UpdateLop(LopDTO lop)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "update LOP set TENLOP = N'" + lop.TENLOP + "', MAKH = '" + lop.MAKH + "' where MALOP = '" + lop.MALOP + "'";
                return DataProvider.ExecSQLQuery(str);
            }
            return false;
        }

        public static SqlDataReader KiemTraMaLop(string malop)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "EXEC SP_KiemTraMaLop '" + malop + "'";
                return DataProvider.ExecSQLDataReader(str);
            }
            return null;
        }

        public static SqlDataReader KiemTraTenLop(string tenlop)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "EXEC SP_KiemTraTenLop N'" + tenlop + "'";
                return DataProvider.ExecSQLDataReader(str);
            }
            return null;
        }
    }
}
