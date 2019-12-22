using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyDiemSinhVien.NhapDiemGUI
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private Dictionary<string, string> m_dictPhanManh;
        #endregion

        #region Constructor
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        #endregion

        #region UI Event
        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            m_dictPhanManh = new Dictionary<string, string>();
        }
        private void rdbLan1_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbLan1.Checked == true)
            //{
            //    rdbLan1.ForeColor = Color.Aqua;
            //    rdbLan2.ForeColor = Color.White;
            //}
            //else
            //{
            //    rdbLan1.ForeColor = Color.White;
            //    rdbLan2.ForeColor = Color.Aqua;
            //}
        }
        #endregion


    }
}