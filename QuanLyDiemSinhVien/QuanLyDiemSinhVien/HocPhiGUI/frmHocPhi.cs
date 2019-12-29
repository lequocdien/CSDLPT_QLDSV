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
using System.Data.SqlClient;
using BUL;
using DTO;

namespace QuanLyDiemSinhVien.HocPhiGUI
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private List<HocPhiDTO> m_lstHocPhi;
        private BindingSource m_bdHocPhi;
        #endregion

        #region Constructor
        public frmHocPhi()
        {
            InitializeComponent();
        }
        #endregion

        #region UI Events
        private void frmHocPhi_Load(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            string strMaSinhVien = cbxMaSinhVien.Text.Trim();
            SqlDataReader objReader = HocPhiBUL.LoadInfoSinhVien(strMaSinhVien);
            if(objReader == null)
            {
                return;
            }

            while (objReader.Read())
            {
                txtHoTen.Text = objReader[0].ToString();
                txtMaLop.Text = objReader[1].ToString();
            }

            m_lstHocPhi = HocPhiBUL.LoadHocPhi(strMaSinhVien);
            if(m_lstHocPhi == null)
            {
                return;
            }
            m_bdHocPhi = new BindingSource();
            m_bdHocPhi.DataSource = m_lstHocPhi;
            InitializeDataGridView();
        }
        #endregion

        #region Utilities
        private void InitializeDataGridView()
        {
            dgvHocPhi.DataSource = m_bdHocPhi;

            dgvHocPhi.Columns["NienKhoa"].HeaderText = "Niên khóa";
            dgvHocPhi.Columns["HocKy"].HeaderText = "Học kỳ";
            dgvHocPhi.Columns["HocPhi"].HeaderText = "Học phí";
            dgvHocPhi.Columns["SoTienDaDong"].HeaderText = "Số tiền đã đóng";
        }
        #endregion
    }
}