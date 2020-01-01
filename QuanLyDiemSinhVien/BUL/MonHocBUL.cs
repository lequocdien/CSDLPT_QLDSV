using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class MonHocBUL
    {
        public static List<MonHocDTO> LoadMonHoc()
        {
            DataTable dt = MonHocDAL.LoadMonHoc();
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            List<MonHocDTO> lstMonHoc = new List<MonHocDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHocDTO objMonHoc = new MonHocDTO();
                objMonHoc.MaMH = dt.Rows[i]["MAMH"].ToString().Trim();
                objMonHoc.TenMH = dt.Rows[i]["TENMH"].ToString().Trim();
                lstMonHoc.Add(objMonHoc);
            }
            return lstMonHoc;
        }

        public static bool InsertMonHoc(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            return MonHocDAL.InsertMonHoc(x_strMaMonHoc, x_strTenMonHoc);
        }

        public static bool UpdateMonHoc(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            return MonHocDAL.UpdateMonHoc(x_strMaMonHoc, x_strTenMonHoc);
        }

        public static bool IsExistedAtTableDiem(string x_strMaMonHoc)
        {
            return MonHocDAL.IsExistedAtTableDiem(x_strMaMonHoc);
        }

        public static bool DeleteMonHoc(string x_strMaMonHoc)
        {
            return MonHocDAL.DeleteMonHoc(x_strMaMonHoc);
        }
    }
}
