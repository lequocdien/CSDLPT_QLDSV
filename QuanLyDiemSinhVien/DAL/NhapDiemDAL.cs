using Common;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class NhapDiemDAL
    {
        public static SqlDataReader LoadPhanManh()
        {
            try
            {
                Data.m_objConnection.Close();
                string strConnectionString = "Data Source=" + Constant.SERVER_NAME + ";Initial Catalog=" + Constant.DATABASE_NAME + ";Integrated Security=True";
                Data.m_objConnection.ConnectionString = strConnectionString;
                Data.m_objConnection.Open();

                return DataProvider.ExecSQLDataReader("SELECT * FROM V_DS_PHANMANH");
            }
            catch
            {
                return null;
            }
        }

        public static bool ChangeServer()
        {
            if (DataProvider.ConnectDatabase())
            {
                return true;
            }
            return false;
        }

        public static SqlDataReader LoadLop()
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT MALOP, TENLOP FROM LOP"));
            }
            return null;
        }

        public static SqlDataReader LoadMonHoc()
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("SELECT MAMH, TENMH FROM MONHOC"));
            }
            return null;
        }

        public static SqlDataReader LoadLanThi(string x_strMaMonHoc, string x_strMaLop)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_SoLanThi '{0}', '{1}'", x_strMaMonHoc, x_strMaLop));
            }
            return null;
        }

        public static SqlDataReader LoadBangDiemSinhVien(string x_strMaLop, string x_strMaMonHoc, int x_nLanThi)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_BangDiemSinhVien '{0}', '{1}', {2}", x_strMaLop, x_strMaMonHoc, x_nLanThi));
            }
            return null;
        }

        public static bool InsertBangDiemSinhVien(List<BangDiemSinhVienDTO> x_lstBangDiem, string x_strMaMonHoc, int x_nLan)
        {
            if (DataProvider.ConnectDatabase())
            {
                SqlTransaction objTrans = Data.m_objConnection.BeginTransaction();
                try
                {
                    SqlCommand objCmd;
                    for (int i = 0; i < x_lstBangDiem.Count; i++)
                    {
                        objCmd = new SqlCommand(string.Format("INSERT INTO DIEM(MASV, MAMH, LAN, DIEM) VALUES('{0}', '{1}', {2}, {3})", x_lstBangDiem[i].MaSinhVien, x_strMaMonHoc, x_nLan, x_lstBangDiem[i].Diem), Data.m_objConnection, objTrans);
                        objCmd.ExecuteNonQuery();
                    }
                    objTrans.Commit();
                    return true;
                }
                catch
                {
                    objTrans.Rollback();
                    return false;
                }
            }
            return false;
        }

        public static bool UpdateBangDiemSinhVien(List<BangDiemSinhVienDTO> x_lstBangDiem, string x_strMaMonHoc, int x_nLan)
        {
            if (DataProvider.ConnectDatabase())
            {
                SqlTransaction objTrans = Data.m_objConnection.BeginTransaction();
                try
                {
                    SqlCommand objCmd;
                    for (int i = 0; i < x_lstBangDiem.Count; i++)
                    {
                        objCmd = new SqlCommand(string.Format("UPDATE DIEM SET DIEM = {0} WHERE MASV = '{1}' AND MAMH = '{2}' AND LAN = {3}", x_lstBangDiem[i].Diem, x_lstBangDiem[i].MaSinhVien, x_strMaMonHoc, x_nLan), Data.m_objConnection, objTrans);
                        objCmd.ExecuteNonQuery();
                    }
                    objTrans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    objTrans.Rollback();
                    return false;
                }
            }
            return false;
        }
    }
}
