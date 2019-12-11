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
using BUL;

namespace QuanLyDiemSinhVien.DangNhapGUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = DangNhapBUL.LoadPhanManh();
            cmbKhoa.DisplayMember = "TENKHOA";//tên field chứa dữ liệu ta chọn
            cmbKhoa.ValueMember = "TENSERVER";//tên field chứa dữ liệu tương ứng với item ta chọn
            cmbKhoa.SelectedIndex = 2;//số thứ tự item (-1 --> count -1)
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Common.Data.servername = cmbKhoa.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            if(DangNhapBUL.KiemTraTaiKhoan(user,pass)==0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (DangNhapBUL.KiemTraTaiKhoan(user, pass) == 1)
            {
                MessageBox.Show("Tài khoản không có quyền truy cập.", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("kết nối thành công", "", MessageBoxButtons.OK);
            frmMain f = new frmMain();
            f.Show();
        }
    }
}