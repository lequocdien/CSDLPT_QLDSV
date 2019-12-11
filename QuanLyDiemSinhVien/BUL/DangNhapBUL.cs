using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class DangNhapBUL
    {
        public static List<DangNhapDTO> LoadPhanManh()
        {
            DataTable dt = DAL.DangNhapDAL.LoadPhanManh();
            if(dt.Rows.Count > 0)
            {
                List<DangNhapDTO> list = new List<DangNhapDTO>();
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    DangNhapDTO obj = new DangNhapDTO();
                    obj.TENKHOA = dt.Rows[i]["TENKHOA"].ToString();
                    obj.TENSERVER = dt.Rows[i]["TENSERVER"].ToString();
                    list.Add(obj);
                }
                return list;
            }
            return null;
        }

        public static int KiemTraTaiKhoan(string user, string pass)
        {
            return DAL.DangNhapDAL.KiemTraTaiKhoan(user, pass);
        }
    }
}
