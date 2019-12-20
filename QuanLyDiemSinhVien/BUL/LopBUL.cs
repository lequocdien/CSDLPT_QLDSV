﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class LopBUL
    {
        public static List<LopDTO> LoadLop()
        {
            DataTable dt = DAL.LopDAL.LoadLop();
            List<LopDTO> list = new List<LopDTO>();
            if (dt.Rows.Count > 0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    LopDTO obj = new LopDTO();
                    obj.MALOP = dt.Rows[i]["MALOP"].ToString();
                    obj.TENLOP = dt.Rows[i]["TENLOP"].ToString();
                    obj.MAKH = dt.Rows[i]["MAKH"].ToString();
                    list.Add(obj);
                }
            }
            return list;
        }

        public static bool AddLop(LopDTO lop)
        {
            return DAL.LopDAL.AddLop(lop);
        }

        public static bool DeleteLop(string malop)
        {
            return DAL.LopDAL.DeleteLop(malop);
        }

        public static bool updateLop(LopDTO lop)
        {
            return DAL.LopDAL.UpdateLop(lop);
        }
    }
}