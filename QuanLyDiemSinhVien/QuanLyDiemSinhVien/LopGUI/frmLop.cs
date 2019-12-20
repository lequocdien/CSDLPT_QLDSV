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
using DTO;

namespace QuanLyDiemSinhVien.LopGUI
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        int maghi;
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLopGUI_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = BUL.LopBUL.LoadLop();
            cmbKhoa.DataSource = BUL.DangNhapBUL.LoadPhanManh();
            cmbKhoa.DisplayMember = "TENKHOA";//tên field chứa dữ liệu ta chọn
            cmbKhoa.ValueMember = "TENSERVER";//tên field chứa dữ liệu tương ứng với item ta chọn
            cmbKhoa.SelectedIndex = Common.Data.m_nKhoa;//vị trí item hiện tại
            txtMaKhoa.Enabled = false;

            if(Common.Data.m_strGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Common.Data.m_strServerName = cmbKhoa.SelectedValue.ToString();
            }
            if (cmbKhoa.SelectedIndex != Common.Data.m_nKhoa)
            {
                Common.Data.m_strLogin = Common.Data.Remote_Login;
                Common.Data.m_strPassword = Common.Data.Remote_Password;
            }
            else
            {
                Common.Data.m_strLogin = Common.Data.m_strLoginDN;
                Common.Data.m_strPassword = Common.Data.m_strPasswordDN;
            }
            if (BUL.DangNhapBUL.KiemTraKetNoi() == false)
            {
                MessageBox.Show("Kết nối về khoa mới thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else
            {
                dgvLop.DataSource = BUL.LopBUL.LoadLop();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maghi = 0;
            cmbKhoa.Enabled = false;
            groupControl_DanhSachLop.Enabled = false;
            txtMaLop.ResetText();
            txtTenLop.ResetText();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }
        int dong;
        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dgvLop.Rows[dong].Cells[1].Value == null)
            {
                return;
            }
            txtMaLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString().Trim();
            txtTenLop.Text = dgvLop.Rows[dong].Cells[2].Value.ToString().Trim();
            txtMaKhoa.Text = dgvLop.Rows[dong].Cells[3].Value.ToString().Trim();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dgvLop.DataSource = BUL.LopBUL.LoadLop();
            MessageBox.Show("Tải lại dữ liệu thành công", "THÔNG BÁO", MessageBoxButtons.OK);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn phục hồi lại thông tin không?", "THÔNG BÁO", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            txtMaLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString().Trim();
            txtTenLop.Text = dgvLop.Rows[dong].Cells[2].Value.ToString().Trim();
            txtMaLop.Enabled = txtTenLop.Enabled = true;
            groupControl_DanhSachLop.Enabled = true;
            if (Common.Data.m_strGroup == "PGV")
            {
                cmbKhoa.Enabled = true; ;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            LopDTO lop = new LopDTO();
            lop.MALOP = txtMaLop.Text.Trim();
            lop.TENLOP = txtTenLop.Text.Trim();
            lop.MAKH = txtMaKhoa.Text.Trim();
            if (MessageBox.Show("Bạn có muốn lưu lại thông tin lớp có mã " + txtMaLop.Text.Trim() + " không?", "THÔNG BÁO", MessageBoxButtons.YesNo) == DialogResult.No) return;
            if (maghi == 0)
            {
                if (BUL.LopBUL.AddLop(lop) == true)
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            if(maghi == 1)
            {
                if (BUL.LopBUL.updateLop(lop) == true)
                {   
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            dgvLop.DataSource = BUL.LopBUL.LoadLop();
            groupControl_DanhSachLop.Enabled = true;
            if (Common.Data.m_strGroup == "PGV")
            {
                cmbKhoa.Enabled = true; ;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BUL.LopBUL.LoadLop().Count == 0)
            {
                MessageBox.Show("Khoa " + cmbKhoa.DisplayMember + " không có lớp", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            string malop = txtMaLop.Text.Trim();
            if (MessageBox.Show("Bạn có muốn xóa lớp" + malop + " không?", "THÔNG BÁO", MessageBoxButtons.YesNo) == DialogResult.No) return;
            if (BUL.LopBUL.DeleteLop(malop)==true)
            {
                MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                dgvLop.DataSource = BUL.LopBUL.LoadLop();
                if (Common.Data.m_strGroup == "PGV")
                {
                    cmbKhoa.Enabled = true; ;
                }
                else
                {
                    cmbKhoa.Enabled = false;
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BUL.LopBUL.LoadLop().Count == 0)
            {
                MessageBox.Show("Khoa "+ cmbKhoa.DisplayMember +" không có lớp", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            maghi = 1;
            txtMaLop.Enabled = false;
            cmbKhoa.Enabled = false;
            groupControl_DanhSachLop.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void dgvLop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for(int i=0; i < dgvLop.RowCount; i++)
            {
                dgvLop.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}