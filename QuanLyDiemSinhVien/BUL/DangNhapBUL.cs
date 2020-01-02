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
        public static DataTable LoadPhanManh()
        {
            return DAL.DangNhapDAL.LoadPhanManh();
        }

        public static int KiemTraTaiKhoan(string user, string pass)
        {
            return DAL.DangNhapDAL.KiemTraTaiKhoan(user, pass);
        }

        public static bool KiemTraKetNoi()
        {
            return DAL.DangNhapDAL.KetNoiKhoaMoi();
        }
    }
}
