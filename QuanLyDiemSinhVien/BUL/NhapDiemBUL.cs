using Common;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BUL
{
    public static class NhapDiemBUL
    {
        public static List<PhanManhDTO> LoadPhanManh()
        {
            SqlDataReader objReader = NhapDiemDAL.LoadPhanManh();
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
            if (NhapDiemDAL.ChangeServer())
            {
                return true;
            }
            return false;
        }

        public static List<LopDTO> LoadLop()
        {
            SqlDataReader objReader = NhapDiemDAL.LoadLop();
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
            SqlDataReader objReader = NhapDiemDAL.LoadMonHoc();
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
            SqlDataReader objReader = NhapDiemDAL.LoadLanThi(x_strMaMonHoc, x_strMaLop);
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

        public static List<BangDiemSinhVienDTO> LoadBangDiemSinhVien(string x_strMaLop, string x_strMaMonHoc, int x_nLanThi)
        {
            SqlDataReader objReader = NhapDiemDAL.LoadBangDiemSinhVien(x_strMaLop, x_strMaMonHoc, x_nLanThi);
            if (objReader == null)
            {
                return null;
            }

            List<BangDiemSinhVienDTO> lstBDSV = new List<BangDiemSinhVienDTO>();
            BangDiemSinhVienDTO objBDSV;
            while (objReader.Read())
            {
                objBDSV = new BangDiemSinhVienDTO();
                objBDSV.MaSinhVien = objReader[0].ToString();
                objBDSV.HoTen = objReader[1].ToString();
                objBDSV.Diem = Convert.ToSingle(objReader[2]);
                lstBDSV.Add(objBDSV);
            }
            return lstBDSV;
        }

        public static bool InsertBangDiemSinhVien(List<BangDiemSinhVienDTO> x_lstBangDiem, string x_strMaMonHoc, int x_nLan)
        {
            return NhapDiemDAL.InsertBangDiemSinhVien(x_lstBangDiem, x_strMaMonHoc, x_nLan);
        }

        public static bool UpdateBangDiemSinhVien(List<BangDiemSinhVienDTO> x_lstBangDiem, string x_strMaMonHoc, int x_nLan)
        {
            return NhapDiemDAL.UpdateBangDiemSinhVien(x_lstBangDiem, x_strMaMonHoc, x_nLan);
        }
    }
}
