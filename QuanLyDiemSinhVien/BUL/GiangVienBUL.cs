using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class GiangVienBUL
    {
        public static List<GiangVienDTO> LoadGiangVien()
        {
            DataTable dt = DAL.GiangVienDAL.LoadGiangVien();
            if (dt == null)
            {
                return null;
            }
            List<GiangVienDTO> list = new List<GiangVienDTO>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GiangVienDTO obj = new GiangVienDTO();
                    obj.MAGV = dt.Rows[i]["MAGV"].ToString();
                    obj.HO = dt.Rows[i]["HO"].ToString();
                    obj.TEN = dt.Rows[i]["TEN"].ToString();
                    obj.MAKH = dt.Rows[i]["MAKH"].ToString();
                    list.Add(obj);
                }
            }
            return list;
        }
    }
}
