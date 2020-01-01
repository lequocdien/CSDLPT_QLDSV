using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiangVienDAL
    {
        public static DataTable LoadGiangVien()
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "select MAGV, HO, TEN, MAKH from GIANGVIEN";
                return DataProvider.ExecSQLQueryDataTable(str);
            }
            return null;
        }
    }
}
