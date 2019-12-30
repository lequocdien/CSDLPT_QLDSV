using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaoTaiKhoanDAL
    {
        public static SqlDataReader TaoTaiKhoan(string login,string password,string user,string role)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = " declare @res int " +
                    "EXEC @res = SP_TAOTAIKHOAN '" + login + "','" + password + "','" + user + "','" + role + "'" +
                    " select KETQUA = @res";
                return DataProvider.ExecSQLDataReader(str);
            }
            return null;
        }
    }
}
