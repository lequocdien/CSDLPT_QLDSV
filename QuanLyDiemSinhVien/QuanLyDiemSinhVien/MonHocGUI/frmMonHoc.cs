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
using DTO;
using BUL;

namespace QuanLyDiemSinhVien.MonHocGUI
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private List<MonHocDTO> m_lstMonHoc;
        #endregion

        #region Constructor
        public frmMonHoc()
        {
            InitializeComponent();
        }
        #endregion

        #region UI Event
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            m_lstMonHoc = MonHocBUL.LoadMonHoc();
            if (m_lstMonHoc == null)
            {
                return;
            }

            dgvMonHoc.DataSource = m_lstMonHoc;
            InitializeDataGridView();
        }

        private void dgvMonHoc_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dgvRow = dgvMonHoc.SelectedRows[0];
            txtMaMonHoc.Text = dgvRow.Cells["MaMH"].Value.ToString();
            txtTenMonHoc.Text = dgvRow.Cells["TenMH"].Value.ToString();
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            string strMaMonHoc = txtMaMonHoc.Text;
            string strTenMonHoc = txtTenMonHoc.Text;

            try
            {
                ValidateInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsDuplicateMaMonHoc())
            {
                MessageBox.Show("Mã môn học đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsDuplicateTenMonHoc())
            {
                MessageBox.Show("Tên môn học đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MonHocBUL.InsertMonHoc(strMaMonHoc, strTenMonHoc))
            {
                MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddMonHocIntoList(strMaMonHoc, strTenMonHoc);
                ReloadDataGridView();
            }
        }

        private void btnCapNhatMonHoc_Click(object sender, EventArgs e)
        {
            string strMaMonHoc = txtMaMonHoc.Text;
            string strTenMonHoc = txtTenMonHoc.Text;

            try
            {
                ValidateInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MonHocBUL.UpdateMonHoc(txtMaMonHoc.Text, txtTenMonHoc.Text))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaBoMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(string.Format("Bạn chắc chẵn muốn xóa môn học '{0}'", txtTenMonHoc.Text.Trim()), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (MonHocBUL.DeleteMonHoc(txtMaMonHoc.Text.Trim()))
            {
                MessageBox.Show("Xóa môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPhucHoiMonHoc_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        #region Utilities
        private void InitializeDataGridView()
        {
            dgvMonHoc.Columns[0].HeaderText = "Mã môn học";
            dgvMonHoc.Columns[1].HeaderText = "Tên môn học";
        }

        private bool IsDuplicateMaMonHoc()
        {
            foreach (MonHocDTO objMonHoc in m_lstMonHoc)
            {
                if (objMonHoc.MaMH.Trim().Equals(txtMaMonHoc.Text.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsDuplicateTenMonHoc()
        {
            foreach (MonHocDTO objMonHoc in m_lstMonHoc)
            {
                if (objMonHoc.TenMH.Trim().Equals(txtTenMonHoc.Text.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        private void ReloadDataGridView()
        {
            dgvMonHoc.DataSource = typeof(List<MonHocDTO>);
            dgvMonHoc.DataSource = m_lstMonHoc;
        }

        private void AddMonHocIntoList(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            MonHocDTO objMonHoc = new MonHocDTO();
            objMonHoc.MaMH = x_strMaMonHoc;
            objMonHoc.TenMH = x_strTenMonHoc;
            m_lstMonHoc.Add(objMonHoc);
        }

        private void UpdateMonHocIntoList(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            MonHocDTO objMonHoc = new MonHocDTO();
            objMonHoc.MaMH = x_strMaMonHoc;
            objMonHoc.TenMH = x_strTenMonHoc;
            m_lstMonHoc.Add(objMonHoc);
        }

        private void ValidateInput()
        {
            string strMaMonHoc = txtMaMonHoc.Text;
            string strTenMonHoc = txtTenMonHoc.Text;

            if (string.IsNullOrWhiteSpace(strMaMonHoc))
            {
                throw new Exception("MÃ MÔN HỌC không được để trống");
            }

            if (string.IsNullOrWhiteSpace(strTenMonHoc))
            {
                throw new Exception("TÊN MÔN HỌC không được để trống");
            }

            //TODO: validate MaLop nchar(8), TenLop (nvarchar(40))
        }
        #endregion
    }
}