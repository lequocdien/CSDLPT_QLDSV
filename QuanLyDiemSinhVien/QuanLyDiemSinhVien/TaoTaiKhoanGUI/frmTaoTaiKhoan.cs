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
using System.Data.SqlClient;
using BUL;

namespace QuanLyDiemSinhVien.TaoTaiKhoanGUI
{
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnChonMaGV_Click(object sender, EventArgs e)
        {
            frmGiangVien f = new frmGiangVien();
            f.Show();
            f.PrintInfoLoginEvent += new frmGiangVien.PrintInfoLoginHandler(MaGiangVien);
        }

        public void MaGiangVien(string MaGV)
        {
            txtUser.Text = MaGV;
        }
        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if(Common.Data.m_strGroup == "PGV")
            {
                rdbPKeToan.Enabled = false;
            }
            if (Common.Data.m_strGroup == "Khoa")
            {
                rdbPGV.Enabled = rdbPKeToan.Enabled = false;
            }
            if (Common.Data.m_strGroup == "PKeToan")
            {
                rdbKhoa.Enabled = rdbPGV.Enabled = false;
            }
        }

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Login không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("User không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string login = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string user = txtUser.Text.Trim();
            string role = "";
            if (rdbPGV.Checked == true)
            {
                role = "PGV";
            }
            else if(rdbKhoa.Checked == true )
            {
                role = "Khoa";
            }
            else if(rdbPKeToan.Checked == true)
            {
                role = "PKeToan";
            }
            SqlDataReader myreader = BUL.TaoTaiKhoanBUL.TaoTaiKhoan(login, pass, user, role);
            if (myreader != null)
            {
                myreader.Read();
                int res = myreader.GetInt32(0);
                if (res == 1)
                {
                    MessageBox.Show("Login đã tồn tại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (res == 2)
                {
                    MessageBox.Show("User đã tồn tại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (res == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại. Vui lòng kiểm tra lại.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}