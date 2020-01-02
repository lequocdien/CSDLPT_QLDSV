using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class PhieuDiemBUL
    {
        public static List<PhieuDiemDTO> LoadPhieuDiem(string x_strMaSV)
        {
            SqlDataReader objReader = PhieuDiemDAL.LoadPhieuDiem(x_strMaSV);
            if (objReader == null)
            {
                return null;
            }
            List<PhieuDiemDTO> lstPhieuDiem = new List<PhieuDiemDTO>();
            PhieuDiemDTO objPD;
            int nSTT = 1;
            while (objReader.Read())
            {
                objPD = new PhieuDiemDTO();
                objPD.STT = nSTT;
                objPD.TenMonHoc = objReader[1].ToString();
                objPD.Diem = float.Parse(objReader[2].ToString());
                lstPhieuDiem.Add(objPD);
                nSTT++;
            }
            return lstPhieuDiem;
        }

        public static string GetHoTen(string x_strMaSV)
        {
            SqlDataReader objReader = PhieuDiemDAL.GetHoTen(x_strMaSV);
            if (objReader == null)
            {
                return null;
            }

            if (objReader.Read())
            {
                return objReader[0].ToString();
            }
            return null;
        }

        public static string GetMaLop(string x_strMaSV)
        {
            SqlDataReader objReader = PhieuDiemDAL.GetMaLop(x_strMaSV);
            if (objReader == null)
            {
                return null;
            }

            if (objReader.Read())
            {
                return objReader[0].ToString();
            }
            return null;
        }
    }
}
