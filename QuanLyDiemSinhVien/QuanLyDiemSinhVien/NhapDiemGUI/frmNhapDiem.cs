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
using BUL;
using DTO;
using Common;

namespace QuanLyDiemSinhVien.NhapDiemGUI
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private Dictionary<string, string> m_dictPhanManh;
        private List<LopDTO> m_lstLop;
        private List<MonHocDTO> m_lstMonHoc;
        #endregion

        #region Constructor
        public frmNhapDiem()
        {
            InitializeComponent();

            InitializeDictPhanManh();

            InitializeListLop();

            InitializeListMonHoc();

            InitializeCombox();
        }
        #endregion

        #region UI Event
        private void frmNhapDiem_Load(object sender, EventArgs e)
        {

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

        #region Utilities
        private void InitializeDictPhanManh()
        {
            m_dictPhanManh = new Dictionary<string, string>();
            DataTable dtPhanManh = DangNhapBUL.LoadPhanManh();
            if (dtPhanManh == null || dtPhanManh.Rows.Count == 0)
            {
                return;
            }
            for (int i = 0; i < dtPhanManh.Rows.Count; i++)
            {
                if(dtPhanManh.Rows[i][0].ToString().Equals(Constant.IGNORE_SITE_PKETOAN) == true)
                {
                    continue;
                }
                m_dictPhanManh.Add(dtPhanManh.Rows[i][0].ToString(), dtPhanManh.Rows[i][1].ToString());
            }
        }

        private void InitializeListLop()
        {
            m_lstLop = LopBUL.LoadLop();
        }

        private void InitializeListMonHoc()
        {
            m_lstMonHoc = MonHocBUL.LoadMonHoc();
        }

        private void InitializeCombox()
        {
            //Initialize ComboBox KHOA
            cbxKhoa.DataSource = new BindingSource(m_dictPhanManh, null);
            cbxKhoa.DisplayMember = "Key";
            cbxKhoa.ValueMember = "Value";

            //Initialize ComboBox LOP
            cbxLop.DataSource = m_lstLop;
            cbxLop.DisplayMember = "TENLOP";
            cbxLop.ValueMember = "MALOP";

            //Initialize ComboBox MON HOC
            cbxMonHoc.DataSource = m_lstMonHoc;
            cbxMonHoc.DisplayMember = "TENMH";
            cbxMonHoc.ValueMember = "MAMH";
        }
        #endregion
    }
}