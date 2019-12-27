using DAL;
using DTO;
using System.Collections.Generic;
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

        public static bool InsertBangDiemSinhVien(List<BangDiemSinhVienDTO> x_lstBangDiem)
        {
            return NhapDiemDAL.InsertBangDiemSinhVien(x_lstBangDiem);
        }

        public static bool UpdateBangDiemSinhVien(List<BangDiemSinhVienDTO> x_lstBangDiem)
        {
            return NhapDiemDAL.UpdateBangDiemSinhVien(x_lstBangDiem);
        }
    }
}
