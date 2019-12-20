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

namespace QuanLyDiemSinhVien.MonHocGUI
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        #region UI Event
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource  = BUL.MonHocBUL.LoadMonHoc();
            InitializeDataGridView();
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            string strMaMonHoc = txtMaMonHoc.Text;
            string strTenMonHoc = txtTenMonHoc.Text;

            if (string.IsNullOrWhiteSpace(strMaMonHoc))
            {
                MessageBox.Show("Mã môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(strTenMonHoc))
            {
                MessageBox.Show("Tên môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //TODO: Kiem tra trung ma
            if(BUL.MonHocBUL.InsertMonHoc(strMaMonHoc, strTenMonHoc))
            {
                MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvMonHoc_Click(object sender, EventArgs e)
        {
            if(dgvMonHoc.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dgvRow = dgvMonHoc.SelectedRows[0];
            txtMaMonHoc.Text = dgvRow.Cells["MaMH"].Value.ToString();
        }
        #endregion 

        #region Utilities
        private void InitializeDataGridView()
        {
            dgvMonHoc.Columns[0].HeaderText = "Mã môn học";
            dgvMonHoc.Columns[1].HeaderText = "Tên môn học";
        }
        #endregion

        
    }
}