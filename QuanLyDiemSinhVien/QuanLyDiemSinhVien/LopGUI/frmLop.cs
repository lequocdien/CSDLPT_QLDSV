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
using System.Data.SqlClient;

namespace QuanLyDiemSinhVien.LopGUI
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        int maghi;
        string tenkhoa = "";//lưu tên khoa
        public frmLop()
        {
            InitializeComponent();
        }
        private void frmLopGUI_Load(object sender, EventArgs e)
        {
            if (BUL.LopBUL.LoadLop() == null)
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                return;
            }
            cmbKhoa.DataSource = Common.Data.bds_2_pm;
            cmbKhoa.DisplayMember = "TENKHOA";//tên field chứa dữ liệu ta chọn
            cmbKhoa.ValueMember = "TENSERVER";//tên field chứa dữ liệu tương ứng với item ta chọn
            cmbKhoa.SelectedIndex = Common.Data.m_nKhoa;//vị trí item hiện tại
            dgvLop.DataSource = BUL.LopBUL.LoadLop();

            ChucNang();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Common.Data.m_strServerName = cmbKhoa.SelectedValue.ToString();
            }
            if (cmbKhoa.SelectedIndex != Common.Data.m_nKhoa)
            {
                Common.Data.m_strLogin = Common.Constant.REMOTE_LOGIN;
                Common.Data.m_strPassword = Common.Constant.REMOTE_PASSWORD;
            }
            else
            {
                Common.Data.m_strLogin = Common.Data.m_strLoginDN;
                Common.Data.m_strPassword = Common.Data.m_strPasswordDN;
            }
            if (BUL.DangNhapBUL.KiemTraKetNoi() == false)
            {
                MessageBox.Show("Kết nối về khoa mới thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = BUL.LopBUL.LoadKhoa();
                tenkhoa = dt.Rows[0]["TENKH"].ToString();//trường hợp chưa có lớp nào
                txtMaKhoa.Text = dt.Rows[0]["MAKH"].ToString();
                dgvLop.DataSource = BUL.LopBUL.LoadLop();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maghi = 0;
            txtMaLop.ReadOnly = txtTenLop.ReadOnly = false;
            cmbKhoa.Enabled = groupControl_DanhSachLop.Enabled = false;
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
                txtMaLop.ResetText();
                return;
            }
            txtMaLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString().Trim();
            txtTenLop.Text = dgvLop.Rows[dong].Cells[2].Value.ToString().Trim();
            txtMaKhoa.Text = dgvLop.Rows[dong].Cells[3].Value.ToString().Trim();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(BUL.LopBUL.LoadLop().Count == 0)
            {
                MessageBox.Show("Khoa "+tenkhoa+" không có lớp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvLop.DataSource = BUL.LopBUL.LoadLop();
            MessageBox.Show("Tải lại dữ liệu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn phục hồi lại thông tin không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (BUL.LopBUL.LoadLop().Count > 0)
            {
                txtMaLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString().Trim();
                txtTenLop.Text = dgvLop.Rows[dong].Cells[2].Value.ToString().Trim();
            }
            else
            {
                txtMaLop.Text = txtTenLop.Text = "";
            }
            ChucNang();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaLop.Text.Trim().Length > 8)
            {
                MessageBox.Show("Mã lớp không quá 8 ký tự", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataReader KTMaLop = BUL.LopBUL.KiemTraMaLop(txtMaLop.Text.Trim());
            if (KTMaLop != null && maghi == 0)
            {
                KTMaLop.Read();
                MessageBox.Show("Mã lớp: "+ txtMaLop.Text.Trim() + " đã tồn tại \nKhoa " + KTMaLop.GetString(0) + "", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataReader KTTenLop = BUL.LopBUL.KiemTraTenLop(txtTenLop.Text.Trim());
            if (KTTenLop != null)
            {
                KTTenLop.Read();
                MessageBox.Show("Tên lớp: "+ txtTenLop.Text.Trim() + " đã tồn tại \nKhoa: "+ KTTenLop.GetString(0)+"", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LopDTO lop = new LopDTO();
            lop.MALOP = txtMaLop.Text.Trim();
            lop.TENLOP = txtTenLop.Text.Trim();
            lop.MAKH = txtMaKhoa.Text.Trim();
            if (MessageBox.Show("Bạn có muốn lưu lại thông tin lớp có mã " + txtMaLop.Text.Trim() + " không?", "THÔNG BÁO", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;
            if (maghi == 0)
            {
                if (BUL.LopBUL.AddLop(lop) == true)
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(maghi == 1)
            {
                if (BUL.LopBUL.updateLop(lop) == true)
                {   
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dgvLop.DataSource = BUL.LopBUL.LoadLop();
            ChucNang();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BUL.LopBUL.LoadLop().Count == 0)
            {
                MessageBox.Show("Khoa " + tenkhoa + " không có lớp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string malop = txtMaLop.Text.Trim();
            if(BUL.SinhVienBUL.LoadSinhVien(malop).Count > 0)
            {
                MessageBox.Show("Lớp "+malop+" có sinh viên không được xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa lớp " + malop + " không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            if (BUL.LopBUL.DeleteLop(malop)==true)
            {
                MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvLop.DataSource = BUL.LopBUL.LoadLop();
            if(BUL.LopBUL.LoadLop().Count == 0)
            {
                txtMaLop.Text = txtTenLop.Text = "";
            }
            ChucNang();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BUL.LopBUL.LoadLop().Count == 0)
            {
                MessageBox.Show("Khoa "+ tenkhoa +" không có lớp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            maghi = 1;
            cmbKhoa.Enabled = groupControl_DanhSachLop.Enabled = false;
            txtTenLop.ReadOnly = false;
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
        private void ChucNang()
        {
            txtMaLop.ReadOnly = txtTenLop.ReadOnly = txtMaKhoa.ReadOnly = true;
            groupControl_DanhSachLop.Enabled = true;
            if (Common.Data.m_strGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = false;
                btnLamMoi.Enabled = btnThoat.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
        }
    }
}