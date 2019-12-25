using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUL
{
    public static class NhapDiemBUL
    {
        public static bool ChangeSever()
        {
            return NhapDiemDAL.ChangeServer();
        }

        public static SqlDataReader LoadBangDiemSinhVien(string x_strMaLop, string x_strMaMonHoc, int x_nLanThi)
        {
            return NhapDiemDAL.LoadBangDiemSinhVien(x_strMaLop, x_strMaMonHoc, x_nLanThi);
        }
    }
}
