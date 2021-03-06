﻿using System;
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
        private AutoCompleteStringCollection m_lstMaSinhVien;
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
            m_lstMaSinhVien = new AutoCompleteStringCollection();
            List<SinhVienDTO> lst = HocPhiBUL.LoadSinhVien();

            if(lst == null)
            {
                return;
            }

            for(int i = 0; i<lst.Count; i++)
            {
                m_lstMaSinhVien.Add(lst[i].MASV.Trim());
            }
            txtMaSV.AutoCompleteCustomSource = m_lstMaSinhVien;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            string strMaSinhVien = txtMaSV.Text.Trim();
            SqlDataReader objReader = HocPhiBUL.LoadInfoSinhVien(strMaSinhVien);
            if (objReader == null)
            {
                return;
            }

            while (objReader.Read())
            {
                txtHoTen.Text = objReader[0].ToString();
                txtMaLop.Text = objReader[1].ToString();
            }

            m_lstHocPhi = HocPhiBUL.LoadHocPhi(strMaSinhVien);
            if (m_lstHocPhi == null)
            {
                return;
            }
            m_bdHocPhi = new BindingSource();
            m_bdHocPhi.DataSource = m_lstHocPhi;
            InitializeDataGridView();
        } 

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string strMaSinhVien = txtMaSV.Text.Trim();
            if (HocPhiBUL.InsertHocPhi(strMaSinhVien, m_lstHocPhi) == false)
            {
                MessageBox.Show("Ghi vào database thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Ghi vào database thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvHocPhi_CellValidating(object x_objSender, DataGridViewCellValidatingEventArgs x_objEventArgs)
        {
            DataGridView dgv = (DataGridView)x_objSender;
            try
            {
                if (x_objEventArgs.ColumnIndex == 1)
                {
                    int nHocKy;
                    if (!int.TryParse(x_objEventArgs.FormattedValue.ToString(), out nHocKy) || nHocKy <= 0)
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvHocPhi.CancelEdit();
                        //dgv.CurrentCell.Value = 1;
                        return;
                    }

                    if(nHocKy > 3)
                    {
                        MessageBox.Show("Chỉ có học kỳ 1; 2; 3!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvHocPhi.CancelEdit();
                        //dgv.CurrentCell.Value = 1;
                        return;
                    }
                }
                else if (x_objEventArgs.ColumnIndex == 2)
                {
                    int nHocPhi;
                    if (!int.TryParse(x_objEventArgs.FormattedValue.ToString(), out nHocPhi) || nHocPhi < 0)
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvHocPhi.CancelEdit();
                        return;
                    }
                }
                else if (x_objEventArgs.ColumnIndex == 3)
                {
                    int nSoTienDaDong;
                    if (!int.TryParse(x_objEventArgs.FormattedValue.ToString(), out nSoTienDaDong) || nSoTienDaDong < 0)
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvHocPhi.CancelEdit();
                        return;
                    }

                    if (nSoTienDaDong < (int)((DataGridView)x_objSender).CurrentRow.Cells["colHocPhi"].Value || nSoTienDaDong > (int)((DataGridView)x_objSender).CurrentRow.Cells["colHocPhi"].Value)
                    {
                        MessageBox.Show("Số tiền đã đóng phải bằng HỌC PHÍ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvHocPhi.CancelEdit();
                        return;
                    }
                }
            }
            catch
            {

            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            string strMaSinhVien = txtMaSV.Text.Trim();
            m_lstHocPhi = HocPhiBUL.LoadHocPhi(strMaSinhVien);
            if (m_lstHocPhi == null)
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
            for (int i = 0; i < dgvHocPhi.RowCount; i++)
            {
                if (i == dgvHocPhi.RowCount - 1)
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