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
            DataTable dt = DAL.MonHocDAL.LoadMonHoc();
            if(dt.Rows.Count > 0)
            {
                List<MonHocDTO> lstMonHoc = new List<MonHocDTO>();
                for(int i = 0; i<dt.Rows.Count; i++)
                {
                    MonHocDTO objMonHoc = new MonHocDTO();
                    objMonHoc.MaMH = dt.Rows[i]["MAMH"].ToString();
                    objMonHoc.TenMH = dt.Rows[i]["TENMH"].ToString();
                    lstMonHoc.Add(objMonHoc);
                }
                return lstMonHoc;
            }
            return null;
        }

        public static bool InsertMonHoc(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            return DAL.MonHocDAL.InsertMonHoc(x_strMaMonHoc, x_strTenMonHoc);
        }
    }
}
