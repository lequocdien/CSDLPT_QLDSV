﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVienDAL
    {
        public static DataTable LoadSinhVien(string MaLop)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "select MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC from SINHVIEN where MALOP = '" + MaLop + "'";
                return DataProvider.ExecSQLQueryDataTable(str);
            }
            return null;
        }

        public static bool AddSinhVien(SinhVienDTO sv)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "insert into SINHVIEN(MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,NGHIHOC,GHICHU) " +
                "values('" + sv.MASV + "',N'" + sv.HO + "',N'" + sv.TEN + "','" + sv.MALOP + "','" + sv.PHAI + "'," +
                "'" + sv.NGAYSINH + "',N'" + sv.NOISINH + "',N'" + sv.DIACHI + "','" + sv.NGHIHOC + "',N'" + sv.GHICHU + "')";
                return DataProvider.ExecSQLQuery(str);
            }
            return false;
        }

        public static bool DeleteSinhVien(string masv)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "delete from SINHVIEN where MASV = '" + masv + "'";
                return DataProvider.ExecSQLQuery(str);
            }
            return false;
        }

        public static bool UpdateSinhVien(SinhVienDTO sv)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "update SINHVIEN set HO = N'" + sv.HO + "', TEN = N'" + sv.TEN + "',MALOP = '" + sv.MALOP + "' ," +
                "PHAI = '" + sv.PHAI + "',NGAYSINH = '" + sv.NGAYSINH + "',NOISINH = N'" + sv.NOISINH + "',DIACHI = N'" + sv.DIACHI + "'," +
                "NGHIHOC = '" + sv.NGHIHOC + "',GHICHU = N'" + sv.GHICHU + "' where MASV = '" + sv.MASV + "'";
                return DataProvider.ExecSQLQuery(str);
            }
            return false;
        }

        public static SqlDataReader KiemTraMaSinhVien(string masv)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "EXEC SP_KiemTraMaSinhVien '" + masv + "'";
                return DataProvider.ExecSQLDataReader(str);
            }
            return null;
        }

        public static DataTable KiemTraHocPhiSinhVien(string masv)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "select MASV from LINK2.CSDLPT_QLDSV.DBO.HOCPHI where MASV = '" + masv + "'";
                return DataProvider.ExecSQLQueryDataTable(str);
            }
            return null;
        }

        public static DataTable KiemTraDiemSinhVien(string masv)
        {
            if (DataProvider.ConnectDatabase())
            {
                string str = "select MASV from DIEM where MASV = '" + masv + "'";
                return DataProvider.ExecSQLQueryDataTable(str);
            }
            return null;
        }
    }
}
