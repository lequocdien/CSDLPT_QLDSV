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
    public class DanhSachThiHetMonBUL
    {
        public static List<DanhSachThiHetMonDTO> LoadDanhSachThiHetMon(string x_strMaLop, string x_strMaMonHoc, int x_nLanThi)
        {
            SqlDataReader objReader = DanhSachThiHetMonDAL.LoadDanhSachThiHetMon(x_strMaLop, x_strMaMonHoc, x_nLanThi);
            if (objReader == null)
            {
                return null;
            }
            List<DanhSachThiHetMonDTO> lstThiHetMon = new List<DanhSachThiHetMonDTO>();
            DanhSachThiHetMonDTO objDSTHM;
            int nSTT = 1;
            while (objReader.Read())
            {
                objDSTHM = new DanhSachThiHetMonDTO();
                objDSTHM.STT = nSTT;
                objDSTHM.MaSinhVien = objReader[0].ToString();
                objDSTHM.HoTen = objReader[1].ToString();
                objDSTHM.SoTo = int.Parse(objReader[2].ToString());
                objDSTHM.Diem = float.Parse(objReader[3].ToString());
                objDSTHM.Chuky = objReader[4].ToString();
                lstThiHetMon.Add(objDSTHM);
                nSTT++;
            }
            return lstThiHetMon;
        }

        public static string GetTenLop(string x_strMaLop)
        {
            SqlDataReader objReader = DanhSachThiHetMonDAL.GetTenLop(x_strMaLop);
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

        public static string GetTenMonHoc(string x_strMaMonHoc)
        {
            SqlDataReader objReader = DanhSachThiHetMonDAL.GetTenMonHoc(x_strMaMonHoc);
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
