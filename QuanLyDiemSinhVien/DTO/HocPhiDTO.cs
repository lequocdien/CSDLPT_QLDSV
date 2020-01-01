using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public class HocPhiDTO
    {
        #region Fields
        private int m_nHocPhi;
        private int m_nSoTienDaDong;
        #endregion

        #region Properties
        public string NienKhoa { set; get; }
        public int HocKy { set; get; }
        public int HocPhi { get; set; }
        public int SoTienDaDong { get; set; }
        #endregion
    }
}
