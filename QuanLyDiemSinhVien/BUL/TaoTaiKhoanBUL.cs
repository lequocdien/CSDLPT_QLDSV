using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class TaoTaiKhoanBUL
    {
        public static SqlDataReader TaoTaiKhoan(string login, string password, string user, string role)
        {
            return DAL.TaoTaiKhoanDAL.TaoTaiKhoan(login, password, user, role);
        }
    }
}
