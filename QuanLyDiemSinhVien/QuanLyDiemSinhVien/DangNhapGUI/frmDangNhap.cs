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
using QuanLyDiemSinhVien.Lop_SinhVienGUI;
using QuanLyDiemSinhVien.LopGUI;
using Common;

namespace QuanLyDiemSinhVien.DangNhapGUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public delegate void PrintInfoLoginHandler(string x_strMaGV, string x_strHoTen, string x_strGroup);

        public event PrintInfoLoginHandler PrintInfoLoginEvent;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Common.Data.bds_dspm.DataSource = DangNhapBUL.LoadPhanManh();
            cmbKhoa.DataSource = DangNhapBUL.LoadPhanManh();
            cmbKhoa.DisplayMember = "TENKHOA";//tên field chứa dữ liệu ta chọn
            cmbKhoa.ValueMember = "TENSERVER";//tên field chứa dữ liệu tương ứng với item ta chọn
            cmbKhoa.SelectedIndex = 1;//số thứ tự item (-1 --> count -1)
            cmbKhoa.SelectedIndex = 0;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Common.Data.m_strServerName = cmbKhoa.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string user = txtTaiKhoan.Text;
            string pass = txtMatKhau.Text;
            if (DangNhapBUL.KiemTraTaiKhoan(user, pass) == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Common.Data.m_nKhoa = cmbKhoa.SelectedIndex;
            if (DangNhapBUL.KiemTraTaiKhoan(user, pass) == 1)
            {
                MessageBox.Show("Tài khoản không có quyền truy cập.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PrintInfoLoginEvent(Data.m_strMaGV, Data.m_strHoten, Data.m_strGroup);

            MessageBox.Show("kết nối thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(cmbKhoa.SelectedValue.ToString().Equals(Common.Constant.IGNORE_SITE_PKETOAN) == false)
            {
                Common.Data.bds_2_pm.DataSource = Load_2_PhanManh();
            }
            this.Close();
            Common.Data.Con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable Load_2_PhanManh()
        {
            DataTable ds = new DataTable();
            ds.Columns.Add("TENKHOA");
            ds.Columns.Add("TENSERVER");

            DataTable dt = new DataTable();
            dt = BUL.DangNhapBUL.LoadPhanManh();
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
    }
}