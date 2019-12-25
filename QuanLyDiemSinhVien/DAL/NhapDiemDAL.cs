using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class NhapDiemDAL
    {
        public static bool ChangeServer()
        {
            return DataProvider.ConnectDatabase();
        }

        public static SqlDataReader LoadBangDiemSinhVien(string x_strMaLop, string x_strMaMonHoc, int x_nLanThi)
        {
            return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_BangDiemSinhVien '{0}', '{1}', {2}", x_strMaLop, x_strMaMonHoc, x_nLanThi));
        }
    }
}
