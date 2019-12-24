using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class SinhVienBUL
    {
        public static List<SinhVienDTO> LoadSinhVien(string Malop)
        {
            DataTable dt = DAL.SinhVienDAL.LoadSinhVien(Malop);
            List<SinhVienDTO> list = new List<SinhVienDTO>();
            if (dt.Rows.Count > 0)
            {
                for(int i = 0;i<dt.Rows.Count;i++)
                {
                    SinhVienDTO obj = new SinhVienDTO();
                    obj.MASV = dt.Rows[i]["MASV"].ToString();
                    obj.HO = dt.Rows[i]["HO"].ToString();
                    obj.TEN = dt.Rows[i]["TEN"].ToString();
                    obj.MALOP = dt.Rows[i]["MALOP"].ToString();
                    obj.PHAI = Convert.ToBoolean(dt.Rows[i]["PHAI"]);
                    obj.NGAYSINH = Convert.ToDateTime(dt.Rows[i]["NGAYSINH"]);
                    obj.NOISINH = dt.Rows[i]["NOISINH"].ToString();
                    obj.DIACHI = dt.Rows[i]["DIACHI"].ToString();
                    obj.NGHIHOC = Convert.ToBoolean(dt.Rows[i]["NGHIHOC"]);
                    obj.GHICHU = dt.Rows[i]["GHICHU"].ToString();
                    list.Add(obj);
                }
            }
            return list;
        }

        public static bool AddSinhVien(SinhVienDTO sv)
        {
            return DAL.SinhVienDAL.AddSinhVien(sv);
        }

        public static bool DeleteSinhVien(string str)
        {
            return DAL.SinhVienDAL.DeleteSinhVien(str);
        }

        public static bool UpdatesinhVien(SinhVienDTO sv)
        {
            return DAL.SinhVienDAL.UpdateSinhVien(sv);
        }
    }
}
