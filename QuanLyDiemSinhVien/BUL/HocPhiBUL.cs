using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class HocPhiBUL
    {
        public static SqlDataReader LoadInfoSinhVien(string x_strMaSinhVien)
        {
            return HocPhiDAL.LoadInfoSinhVien(x_strMaSinhVien);
        }

        public static List<HocPhiDTO> LoadHocPhi(string x_strMaSinhVien)
        {
            SqlDataReader objReader = HocPhiDAL.LoadHocPhi(x_strMaSinhVien);
            if(objReader == null)
            {
                return null;
            }

            List<HocPhiDTO> lstHocPhi = new List<HocPhiDTO>();
            HocPhiDTO objHocPhi;
            while (objReader.Read())
            {
                objHocPhi = new HocPhiDTO();
                objHocPhi.NienKhoa = objReader[0].ToString();
                objHocPhi.HocKy = int.Parse(objReader[1].ToString());
                objHocPhi.HocPhi = int.Parse(objReader[2].ToString());
                objHocPhi.SoTienDaDong = int.Parse(objReader[3].ToString());
                lstHocPhi.Add(objHocPhi);
            }
            return lstHocPhi;
        }

        public static bool InsertHocPhi(string x_strMaSinhVien, List<HocPhiDTO> x_lstHocPhi)
        {
            return HocPhiDAL.InsertHocPhi(x_strMaSinhVien, x_lstHocPhi);
        }
    }
}
