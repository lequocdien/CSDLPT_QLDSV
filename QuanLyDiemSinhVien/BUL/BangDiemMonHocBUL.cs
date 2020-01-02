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
    public class BangDiemMonHocBUL
    {
        public static List<BangDiemMonHocDTO> LoadBangDiemMonHoc(string x_strMaLop, string x_strMaMH, int x_nLanThi)
        {
            SqlDataReader objReader = BangDiemMonHocDAL.LoadBangDiemMonHoc(x_strMaLop, x_strMaMH, x_nLanThi);
            if (objReader == null)
            {
                return null;
            }
            List<BangDiemMonHocDTO> lstBDMH = new List<BangDiemMonHocDTO>();
            BangDiemMonHocDTO objBDMH;
            int nSTT = 1;
            while (objReader.Read())
            {
                objBDMH = new BangDiemMonHocDTO();
                objBDMH.STT = nSTT;
                objBDMH.HoVaTen = objReader[1].ToString();
                objBDMH.Diem = float.Parse(objReader[2].ToString());
                lstBDMH.Add(objBDMH);
                nSTT++;
            }
            return lstBDMH;
        }

        public static string GetTenMonHoc(string x_strMaMH)
        {
            SqlDataReader objReader = BangDiemMonHocDAL.GetTenMonHoc(x_strMaMH);
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

        public static string GetTenLop(string x_strMaLop)
        {
            SqlDataReader objReader = BangDiemMonHocDAL.GetTenLop(x_strMaLop);
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
