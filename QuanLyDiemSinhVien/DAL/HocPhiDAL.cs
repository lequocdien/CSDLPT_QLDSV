using Common;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocPhiDAL
    {
        public static SqlDataReader LoadInfoSinhVien(string x_strMaSinhVien)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_LoadInfoSinhVien '{0}'", x_strMaSinhVien));
            }
            return null;
        }

        public static SqlDataReader LoadHocPhi(string x_strMaSinhVien)
        {
            if (DataProvider.ConnectDatabase())
            {
                return DataProvider.ExecSQLDataReader(string.Format("EXEC sp_LoadHocPhi '{0}'", x_strMaSinhVien));
            }
            return null;
        }

        public static bool InsertHocPhi(string x_strMaSinhVien, List<HocPhiDTO> x_lstHocPhi)
        {
            if (DataProvider.ConnectDatabase())
            {
                SqlTransaction objTrans = Data.Con.BeginTransaction();
                try
                {
                    SqlCommand objCmd;
                    for (int i = 0; i < x_lstHocPhi.Count; i++)
                    {
                        objCmd = new SqlCommand(string.Format("INSERT INTO HOCPHI(MASV, NIENKHOA, HOCKY, HOCPHI, SOTIENDADONG) VALUES('{0}', '{1}', {2}, {3}, {4})", x_strMaSinhVien, x_lstHocPhi[i].NienKhoa, x_lstHocPhi[i].HocKy, x_lstHocPhi[i].HocPhi, x_lstHocPhi[i].SoTienDaDong), Data.Con, objTrans);
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
