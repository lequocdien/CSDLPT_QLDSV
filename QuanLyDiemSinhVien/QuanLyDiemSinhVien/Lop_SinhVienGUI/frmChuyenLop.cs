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

namespace QuanLyDiemSinhVien.Lop_SinhVienGUI
{
    public partial class frmChuyenLop : DevExpress.XtraEditors.XtraForm
    {
        string MaLop = "";
        public frmChuyenLop()
        {
            InitializeComponent();
        }

        private void frmChuyenLop_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = BUL.LopBUL.LoadLop();
        }

        private void dgvDanhSachLop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvLop.RowCount; i++)
            {
                dgvLop.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.ResetText();
            dgvLop.DataSource = BUL.LopBUL.LoadLop();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<DTO.LopDTO> list = new List<DTO.LopDTO>();
            list = BUL.LopBUL.TimKiemLop(txtMaLop.Text.Trim());
            if (list.Count == 0)
            {
                MessageBox.Show("Lớp "+ txtMaLop.Text.Trim() + " không có trong danh sách ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                dgvLop.DataSource = list;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.MASV = frmLop_SinhVien.sinhvien.sv.MASV;
            sv.HO = frmLop_SinhVien.sinhvien.sv.HO;
            sv.TEN = frmLop_SinhVien.sinhvien.sv.TEN;
            sv.MALOP = txtMaLop.Text.Trim();
            sv.NGAYSINH = frmLop_SinhVien.sinhvien.sv.NGAYSINH;
            sv.NOISINH = frmLop_SinhVien.sinhvien.sv.NOISINH;
            sv.DIACHI = frmLop_SinhVien.sinhvien.sv.DIACHI;
            sv.GHICHU = frmLop_SinhVien.sinhvien.sv.GHICHU;
            sv.PHAI = frmLop_SinhVien.sinhvien.sv.PHAI;
            sv.NGHIHOC = frmLop_SinhVien.sinhvien.sv.NGHIHOC;

            if(MessageBox.Show("Bạn có muốn chuyển sinh viên có mã " + sv.MASV + " vào lớp "+sv.MALOP+" không? ", "THÔNG BÁO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUL.SinhVienBUL.UpdatesinhVien(sv) == true)
                {
                    MessageBox.Show("Chuyển lớp thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Chuyển lớp thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            return;
        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dgvLop.Rows[dong].Cells[1].Value == null)
            {
                return;
            }
            txtMaLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString().Trim();
            MaLop = txtMaLop.Text.Trim();
        }
    }
}