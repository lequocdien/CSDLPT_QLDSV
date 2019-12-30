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

        public static bool InsertBangDiemSinhVien(List<BangDiemSinhVienDTO> x_lstBangDiem, string x_strMaMonHoc, int x_nLan)
        {
            return NhapDiemDAL.InsertBangDiemSinhVien(x_lstBangDiem, x_strMaMonHoc, x_nLan);
        }

        public static bool UpdateBangDiemSinhVien(List<BangDiemSinhVienDTO> x_lstBangDiem, string x_strMaMonHoc, int x_nLan)
        {
            return NhapDiemDAL.UpdateBangDiemSinhVien(x_lstBangDiem, x_strMaMonHoc, x_nLan);
        }

        public static int CountSoLanThi(string x_strMaMonHoc, string x_strMaLop)
        {
            SqlDataReader objReader = NhapDiemDAL.CountSoLanThi(x_strMaMonHoc, x_strMaLop);
            if(objReader == null)
            {
                //Erorr
                return -1;
            }

            int nSoLanThi = 0;
            if (objReader.Read())
            {
                int.TryParse(objReader[0].ToString(), out nSoLanThi);
            }

            return nSoLanThi;
        }
    }
}
