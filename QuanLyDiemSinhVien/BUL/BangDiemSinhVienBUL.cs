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
    public class BangDiemSinhVienBUL
    {
        public static List<PhanManhDTO> LoadPhanManh()
        {
            SqlDataReader objReader = BangDiemSinhVienDAL.LoadPhanManh();
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
            SqlDataReader objReader = BangDiemSinhVienDAL.LoadLop();
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

        public static List<SinhVienDTO> LoadSinhVien()
        {
            SqlDataReader objReader = BangDiemSinhVienDAL.LoadSinhVien();
            if (objReader == null)
            {
                return null;
            }

            List<SinhVienDTO> lstSinhVien = new List<SinhVienDTO>();
            SinhVienDTO objSinhVien;
            while (objReader.Read())
            {
                objSinhVien = new SinhVienDTO();
                objSinhVien.MASV = objReader[0].ToString();
                lstSinhVien.Add(objSinhVien);
            }
            return lstSinhVien;
        }

        public static List<PhieuDiemDTO> LoadPhieuDiem(string x_strMaSV)
        {
            SqlDataReader objReader = BangDiemSinhVienDAL.LoadPhieuDiem(x_strMaSV);
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
            SqlDataReader objReader = BangDiemSinhVienDAL.GetHoTen(x_strMaSV);
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
            SqlDataReader objReader = BangDiemSinhVienDAL.GetMaLop(x_strMaSV);
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
