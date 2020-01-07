using Common;
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
        public static List<PhanManhDTO> LoadPhanManh()
        {
            SqlDataReader objReader = BangDiemMonHocDAL.LoadPhanManh();
            if (objReader == null)
            {
                return null;
            }

            List<PhanManhDTO> lstPhanManh = new List<PhanManhDTO>();
            PhanManhDTO objPM;
            while (objReader.Read())
            {
                objPM = new PhanManhDTO();
                objPM.TenKhoa = objReader[0].ToString();
                objPM.TenServer = objReader[1].ToString();
                if (objPM.TenKhoa.ToUpper().Trim().Equals(Constant.PUBLICATION_NAME_KT))
                {
                    continue;
                }
                lstPhanManh.Add(objPM);
            }
            return lstPhanManh;
        }

        public static bool ChangeServer()
        {
            if (DanhSachThiHetMonDAL.ChangeServer())
            {
                return true;
            }
            return false;
        }

        public static List<LopDTO> LoadLop()
        {
            SqlDataReader objReader = BangDiemMonHocDAL.LoadLop();
            if (objReader == null)
            {
                return null;
            }

            List<LopDTO> lstLop = new List<LopDTO>();
            LopDTO objLop;
            while (objReader.Read())
            {
                objLop = new LopDTO();
                objLop.MALOP = objReader[0].ToString();
                objLop.TENLOP = objReader[1].ToString();
                lstLop.Add(objLop);
            }
            return lstLop;
        }

        public static List<MonHocDTO> LoadMonHoc()
        {
            SqlDataReader objReader = BangDiemMonHocDAL.LoadMonHoc();
            if (objReader == null)
            {
                return null;
            }

            List<MonHocDTO> lstMonHoc = new List<MonHocDTO>();
            MonHocDTO objMonHoc;
            while (objReader.Read())
            {
                objMonHoc = new MonHocDTO();
                objMonHoc.MaMH = objReader[0].ToString();
                objMonHoc.TenMH = objReader[1].ToString();
                lstMonHoc.Add(objMonHoc);
            }
            return lstMonHoc;
        }

        public static List<string> LoadLanThi(string x_strMaMonHoc, string x_strMaLop)
        {
            SqlDataReader objReader = BangDiemMonHocDAL.LoadLanThi(x_strMaMonHoc, x_strMaLop);
            if (objReader == null)
            {
                return null;
            }

            List<string> lstLanThi = new List<string>();
            while (objReader.Read())
            {

                lstLanThi.Add(objReader[0].ToString());
            }
            return lstLanThi;
        }

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
                objBDMH.HoVaTen = objReader[0].ToString();
                objBDMH.Diem = float.Parse(objReader[1].ToString());
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
