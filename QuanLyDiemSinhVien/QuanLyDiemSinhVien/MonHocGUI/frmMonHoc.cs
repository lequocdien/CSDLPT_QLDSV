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
using Common;

namespace QuanLyDiemSinhVien.MonHocGUI
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private List<MonHocDTO> m_lstMonHoc;
        private BindingSource m_bdsMonHoc;
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
            if (Data.m_strGroup.Trim().ToUpper().Equals("KHOA"))
            {
                txtMaMonHoc.Enabled = false;
                txtTenMonHoc.Enabled = false;
                btnThemMonHoc.Enabled = false;
                btnCapNhatMonHoc.Enabled = false;
                btnXoaBoMonHoc.Enabled = false;
                dgvMonHoc.AllowUserToAddRows = false;
            }
            m_bdsMonHoc = new BindingSource();
            ReloadGUI();
        }

        private void dgvMonHoc_Click(object sender, EventArgs e)
        {
            ToggleTextBoxAndButton();
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            string strMaMonHoc = txtMaMonHoc.Text.Trim();
            string strTenMonHoc = txtTenMonHoc.Text.Trim();

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
                ReloadGUI();
            }
        }

        private void btnCapNhatMonHoc_Click(object sender, EventArgs e)
        {
            string strMaMonHoc = txtMaMonHoc.Text.Trim();
            string strTenMonHoc = txtTenMonHoc.Text.Trim();

            try
            {
                ValidateInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MonHocBUL.UpdateMonHoc(strMaMonHoc, strTenMonHoc))
            {
                MessageBox.Show("Cập nhật môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateMonHocIntoList(strMaMonHoc, strTenMonHoc);
                ReloadGUI();
            }
        }

        private void btnXoaBoMonHoc_Click(object sender, EventArgs e)
        {
            string strMaMonHoc = txtMaMonHoc.Text.Trim();

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

            if (MonHocBUL.IsExistedAtTableDiem(strMaMonHoc))
            {
                MessageBox.Show("Môn học này không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MonHocBUL.DeleteMonHoc(txtMaMonHoc.Text.Trim()))
            {
                MessageBox.Show("Xóa môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeleteMonHocIntoList(strMaMonHoc);
                ReloadGUI();
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            ReloadGUI();
        }

        private void btnPhucHoiMonHoc_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        #region Utilities

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

        private void AddMonHocIntoList(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            MonHocDTO objMonHoc = new MonHocDTO();
            objMonHoc.MaMH = x_strMaMonHoc;
            objMonHoc.TenMH = x_strTenMonHoc;
            m_lstMonHoc.Add(objMonHoc);
        }

        private void UpdateMonHocIntoList(string x_strMaMonHoc, string x_strTenMonHoc)
        {
            for(int i = 0; i<m_lstMonHoc.Count; i++)
            {
                if (m_lstMonHoc[i].MaMH.Equals(x_strMaMonHoc.Trim()))
                {
                    m_lstMonHoc[i].TenMH = x_strTenMonHoc.Trim();
                    return;
                }
            }
        }

        private void DeleteMonHocIntoList(string x_strMaMonHoc)
        {
            for (int i = 0; i < m_lstMonHoc.Count; i++)
            {
                if (m_lstMonHoc[i].MaMH.Equals(x_strMaMonHoc.Trim()))
                {
                    try
                    {
                        m_lstMonHoc.RemoveAt(i);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void ValidateInput()
        {
            string strMaMonHoc = txtMaMonHoc.Text.Trim();
            string strTenMonHoc = txtTenMonHoc.Text.Trim();

            if (string.IsNullOrWhiteSpace(strMaMonHoc))
            {
                throw new Exception("MÃ MÔN HỌC không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(strTenMonHoc))
            {
                throw new Exception("TÊN MÔN HỌC không được để trống!");
            }

            if(strMaMonHoc.Length > 8)
            {
                throw new Exception("MÃ MÔN HỌC quá dài!");
            }

            if (strTenMonHoc.Length > 40)
            {
                throw new Exception("MÃ MÔN HỌC quá dài!");
            }
        }

        private void ReloadGUI()
        {
            LoadDataGridView();
            ToggleTextBoxAndButton();
        }

        private void LoadDataGridView()
        {
            m_lstMonHoc = MonHocBUL.LoadMonHoc();
            if (m_lstMonHoc == null)
            {
                return;
            }
            m_bdsMonHoc.DataSource = m_lstMonHoc;
            m_bdsMonHoc.Sort = "MAMH ASC";
            dgvMonHoc.DataSource = typeof(BindingSource);
            dgvMonHoc.DataSource = m_bdsMonHoc;
        }

        private void ToggleTextBoxAndButton()
        {
            DataGridViewRow dgvRow = dgvMonHoc.SelectedRows[0];
            if (Data.m_strGroup.Trim().ToUpper().Equals("KHOA"))
            {
                txtMaMonHoc.Text = dgvRow.Cells[0].Value.ToString().Trim();
                txtTenMonHoc.Text = dgvRow.Cells[1].Value.ToString().Trim();
                return;
            }
            
            if (dgvMonHoc.Rows.Count - 1 == dgvRow.Index)
            {
                txtMaMonHoc.Text = string.Empty;
                txtTenMonHoc.Text = string.Empty;
                txtMaMonHoc.Enabled = true;
                txtTenMonHoc.Enabled = true;

                btnThemMonHoc.Enabled = true;
                btnCapNhatMonHoc.Enabled = false;
                btnXoaBoMonHoc.Enabled = false;

                return;
            }

            txtMaMonHoc.Text = dgvRow.Cells[0].Value.ToString().Trim();
            txtTenMonHoc.Text = dgvRow.Cells[1].Value.ToString().Trim();
            txtMaMonHoc.Enabled = false;
            txtTenMonHoc.Enabled = true;

            btnThemMonHoc.Enabled = false;
            btnCapNhatMonHoc.Enabled = true;
            btnXoaBoMonHoc.Enabled = true;
        }
        #endregion
    }
}