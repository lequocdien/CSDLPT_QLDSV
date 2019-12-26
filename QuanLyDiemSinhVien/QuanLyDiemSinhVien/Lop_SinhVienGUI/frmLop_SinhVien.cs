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

namespace QuanLyDiemSinhVien.Lop_SinhVienGUI
{
    public partial class frmLop_SinhVien : DevExpress.XtraEditors.XtraForm
    {
        int maghi;
        public frmLop_SinhVien()
        {
            InitializeComponent();
        }
        public class sinhvien
        {
            public static SinhVienDTO sv;
        }
        private DataTable loadphanmanh()
        {
            DataTable ds = new DataTable();
            DataTable dt = BUL.DangNhapBUL.LoadPhanManh();
            ds.Columns.Add("TENKHOA");
            ds.Columns.Add("TENSERVER");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString().Equals(Common.Constant.IGNORE_SITE_PKETOAN) == true)
                {
                    continue;
                }
                string[] arr = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString() };
                ds.Rows.Add(arr);
            }
            return ds;
        }
        private void frmLop_SinhVien_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = loadphanmanh();
            cmbKhoa.DisplayMember = "TENKHOA";//tên field chứa dữ liệu ta chọn
            cmbKhoa.ValueMember = "TENSERVER";//tên field chứa dữ liệu tương ứng với item ta chọn
            cmbKhoa.SelectedIndex = Common.Data.m_nKhoa;//vị trí item hiện tại

            dgvLop.DataSource = BUL.LopBUL.LoadLop();
            txtMaLop.Enabled = false;
            ChucNang();
        }

        string malop = "";
        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dgvLop.Rows[dong].Cells[1].Value == null)
            {
                return;
            }
            if (malop == dgvLop.Rows[dong].Cells[1].Value.ToString().Trim())
            {
                return;// tránh load lại lớp
            }
            malop = dgvLop.Rows[dong].Cells[1].Value.ToString().Trim();
            if(BUL.SinhVienBUL.LoadSinhVien(malop) == null)
            {
                return;
            }
            dgvSinhVien.DataSource = BUL.SinhVienBUL.LoadSinhVien(malop);
            if (BUL.SinhVienBUL.LoadSinhVien(malop).Count == 0)
            {
                txtMaLop.Text = malop;
                txtMaSV.Text = txtHo.Text = txtTen.Text = txtNgaySinh.Text = txtNoiSinh.Text = txtDiaChi.Text = txtGhiChu.Text = "";
                rdbtnNam.Checked = rdbtnNu.Checked = rdbtnDaNghiHoc.Checked = rdbtnChuaNghiHoc.Checked = false;
                return;
            }
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
                dgvLop.DataSource = BUL.LopBUL.LoadLop();
            }
        }

        private void dgvLop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvLop.RowCount; i++)
            {
                dgvLop.Rows[i].Cells[0].Value = i + 1;
            }
        }

        int dong;
        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dgvSinhVien.Rows[dong].Cells[1].Value == null)
            {
                return;
            }
            LoadThongTin_SinhVien(dong);
        }

        private void dgvSinhVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvSinhVien.RowCount; i++)
            {
                dgvSinhVien.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maghi = 0;
            cmbKhoa.Enabled = false;
            txtMaSV.Enabled = true;
            groupControl_DanhSachLop.Enabled = groupControl_DanhSachSinhVien.Enabled = false;
            txtMaSV.Text = txtHo.Text = txtTen.Text  = txtNgaySinh.Text = txtNoiSinh.Text = txtDiaChi.Text = txtGhiChu.Text = "";
            rdbtnNam.Checked = rdbtnNu.Checked = rdbtnDaNghiHoc.Checked = rdbtnChuaNghiHoc.Checked = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = btnChuyenLop.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn phục hồi lại thông tin không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ChucNang();
            if (BUL.SinhVienBUL.LoadSinhVien(malop).Count == 0)
            {
                txtMaSV.Text = txtHo.Text = txtTen.Text = txtNgaySinh.Text = txtNoiSinh.Text = txtDiaChi.Text = txtGhiChu.Text = "";
                rdbtnNam.Checked = rdbtnNu.Checked = rdbtnDaNghiHoc.Checked = rdbtnChuaNghiHoc.Checked = false;
                return;
            }
            LoadThongTin_SinhVien(dong);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BUL.SinhVienBUL.LoadSinhVien(malop).Count == 0)
            {
                MessageBox.Show("Lớp "+malop+" không có sinh viên để chỉnh sửa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            maghi = 1;
            cmbKhoa.Enabled = false;
            groupControl_DanhSachLop.Enabled = groupControl_DanhSachSinhVien.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = btnChuyenLop.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (BUL.SinhVienBUL.LoadSinhVien(malop).Count == 0)
            //{
            //    MessageBox.Show("Lớp " + malop + " không có sinh viên", "THÔNG BÁO", MessageBoxButtons.OK);
            //    return;
            //}
            dgvSinhVien.DataSource = BUL.SinhVienBUL.LoadSinhVien(malop);
            MessageBox.Show("Tải lại dữ liệu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BUL.SinhVienBUL.LoadSinhVien(malop).Count == 0)
            {
                MessageBox.Show("Lớp " + malop + " không có sinh viên để xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string masv = txtMaSV.Text.Trim();
            bool nghihoc = rdbtnDaNghiHoc.Checked;
            if(nghihoc == false)
            {
                MessageBox.Show("Sinh viên "+masv+" còn học không được xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(BUL.SinhVienBUL.KiemTraHocPhiSinhVien(masv).Rows.Count > 0)
            {
                MessageBox.Show("Sinh viên " + masv + " đã dữ liệu học phí không thể xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BUL.SinhVienBUL.KiemTraDiemSinhVien(masv).Rows.Count > 0)
            {
                MessageBox.Show("Sinh viên " + masv + " đã nhập điểm không thể xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa sinh viên có mã "+masv+" không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUL.SinhVienBUL.DeleteSinhVien(masv) == true)
                {
                    MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSinhVien.DataSource = BUL.SinhVienBUL.LoadSinhVien(malop);
                    ChucNang();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
  
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaSV.Text.Trim().Length > 8)
            {
                MessageBox.Show("Mã sinh viên không quá 8 ký tự", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(rdbtnNam.Checked == false && rdbtnNu.Checked == false)
            {
                MessageBox.Show("Giới tính không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNoiSinh.Text.Trim() == "")
            {
                MessageBox.Show("Nơi sinh không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(rdbtnDaNghiHoc.Checked == false && rdbtnChuaNghiHoc.Checked == false)
            {
                MessageBox.Show("Nghỉ học không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataReader KT = BUL.SinhVienBUL.KiemTraMaSinhVien(txtMaSV.Text.Trim());
            if (KT != null && maghi == 0)
            {
                KT.Read();
                MessageBox.Show("Mã sinh viên: " + txtMaSV.Text.Trim() + " đã tồn tại \nLớp: " + KT.GetString(1) + " \nKhoa: " + KT.GetString(0) + "", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SinhVienDTO sv = new SinhVienDTO();
            SinhVienData(sv);
            if (MessageBox.Show("Bạn có muốn lưu lại thông tin sinh viên có mã " + txtMaSV.Text.Trim() + " không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            if (maghi == 0)//thêm
            {
                if(BUL.SinhVienBUL.AddSinhVien(sv) == true)
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            if(maghi == 1)//sửa 
            {
                if (BUL.SinhVienBUL.UpdatesinhVien(sv) == true)
                {
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dgvSinhVien.DataSource = BUL.SinhVienBUL.LoadSinhVien(malop);
            ChucNang();
        }

        private void btnChuyenLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(rdbtnDaNghiHoc.Checked == true)
            {
                MessageBox.Show("Sinh viên có mã "+ txtMaSV.Text.Trim() + " đã nghỉ học\nkhông được chuyển lớp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SinhVienDTO sv = new SinhVienDTO();
            SinhVienData(sv);
            sinhvien.sv = sv;
            frmChuyenLop f = new frmChuyenLop();
            f.Show();
        }

        private void ChucNang()
        {
            if (Common.Data.m_strGroup == "PGV")
            {
                txtMaSV.Enabled = false;
                groupControl_DanhSachLop.Enabled = groupControl_DanhSachSinhVien.Enabled = true;
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnChuyenLop.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = false;
                btnLamMoi.Enabled = btnThoat.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnChuyenLop.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
        }
        private void SinhVienData(SinhVienDTO sv)
        {
            sv.MASV = txtMaSV.Text.Trim();
            sv.HO = txtHo.Text.Trim();
            sv.TEN = txtTen.Text.Trim();
            sv.MALOP = txtMaLop.Text.Trim();
            sv.NGAYSINH = Convert.ToDateTime(txtNgaySinh.Text.Trim());
            sv.NOISINH = txtNoiSinh.Text.Trim();
            sv.DIACHI = txtDiaChi.Text.Trim();
            sv.GHICHU = txtGhiChu.Text.Trim();
            if (rdbtnNam.Checked == true && rdbtnNu.Checked == false)
            {
                sv.PHAI = true;
            }
            else if (rdbtnNam.Checked == false && rdbtnNu.Checked == true)
            {
                sv.PHAI = false;
            }
            if (rdbtnDaNghiHoc.Checked == true && rdbtnChuaNghiHoc.Checked == false)
            {
                sv.NGHIHOC = true;
            }
            else if (rdbtnDaNghiHoc.Checked == false && rdbtnChuaNghiHoc.Checked == true)
            {
                sv.NGHIHOC = false;
            }
        }
        private void LoadThongTin_SinhVien(int dong)
        {
            txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString().Trim();
            txtHo.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString().Trim();
            txtTen.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString().Trim();
            txtMaLop.Text = dgvSinhVien.Rows[dong].Cells[4].Value.ToString().Trim();
            if (dgvSinhVien.Rows[dong].Cells[5].Value.Equals(true))
            {
                rdbtnNam.Checked = true;
            }
            else
            {
                rdbtnNu.Checked = true;
            }
            txtNgaySinh.Text = dgvSinhVien.Rows[dong].Cells[6].Value.ToString().Trim();
            txtNoiSinh.Text = dgvSinhVien.Rows[dong].Cells[7].Value.ToString().Trim();
            txtDiaChi.Text = dgvSinhVien.Rows[dong].Cells[8].Value.ToString().Trim();
            if (dgvSinhVien.Rows[dong].Cells[9].Value.Equals(true))
            {
                rdbtnDaNghiHoc.Checked = true;
            }
            else
            {
                rdbtnChuaNghiHoc.Checked = true;
            }
            txtGhiChu.Text = dgvSinhVien.Rows[dong].Cells[10].Value.ToString().Trim();
        }
    }
}