﻿using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhapDAL
    {
        public static DataTable LoadPhanManh()
        {
            Data.m_objConnection.Close();
            string chuoiketnoi = "Data Source="+Constant.SERVER_NAME+";Initial Catalog="+Constant.DATABASE_NAME+";Integrated Security=True";
            Data.m_objConnection.ConnectionString = chuoiketnoi;
            Data.m_objConnection.Open();
            return DataProvider.ExecSQLQueryDataTable("SELECT * FROM V_DS_PHANMANH");
        }

        public static int KiemTraTaiKhoan(string user, string password)
        {
            Data.m_strLogin = user;
            Data.m_strPassword = password;
            if (DataProvider.ConnectDatabase() == false)
            {
                return 0;
            }
            Data.m_strLoginDN = Data.m_strLogin;
            Data.m_strPasswordDN = Data.m_strPassword;
            string str = "EXEC SP_DANGNHAP'" + Data.m_strLogin + "'";
            SqlDataReader myReader;
            myReader = DataProvider.ExecSQLDataReader(str);
            if (myReader == null)
            {
                return 0;
            }
            myReader.Read();
            Data.m_strMaGV = myReader.GetString(0);
            if (Convert.IsDBNull(Data.m_strMaGV))
            {
                return 1;//Tài khoản ko có quyền truy cập
            }
            else
            {
                Data.m_strHoten = myReader.GetString(1);
                Data.m_strGroup = myReader.GetString(2);
                Data.m_objConnection.Close();
                return 2;//Đăng nhập thành công
            }
        }

        public static bool KetNoiKhoaMoi()
        {
            return DataProvider.ConnectDatabase();
        }
    }
}
