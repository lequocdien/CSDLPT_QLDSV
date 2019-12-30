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

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string strMaSinhVien = cbxMaSinhVien.Text.Trim();
            if(HocPhiBUL.InsertHocPhi(strMaSinhVien, m_lstHocPhi) == false)
            {
                MessageBox.Show("Ghi vào database thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Ghi vào database thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvHocPhi_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                if(dgv.CurrentRow.Cells[e.ColumnIndex].FormattedValue.GetType() != dgv.CurrentRow.Cells[e.ColumnIndex].Value.GetType())
                {
                    MessageBox.Show("Input không hợp lệ");
                    dgv.CancelEdit();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Utilities
        private void InitializeDataGridView()
        {
            dgvHocPhi.DataSource = m_bdHocPhi;

            dgvHocPhi.Columns["colNienKhoa"].HeaderText = "Niên khóa";
            dgvHocPhi.Columns["colHocKy"].HeaderText = "Học kỳ";
            dgvHocPhi.Columns["colHocPhi"].HeaderText = "Học phí";
            dgvHocPhi.Columns["colSoTienDaDong"].HeaderText = "Số tiền đã đóng";

            for(int i = 0; i<dgvHocPhi.RowCount; i++)
            {
                if(i == dgvHocPhi.RowCount - 1)
                {
                    dgvHocPhi.Rows[i].ReadOnly = false;
                }
                else
                {
                    dgvHocPhi.Rows[i].ReadOnly = true;
                }
            }
        }

        #endregion

        
    }
}