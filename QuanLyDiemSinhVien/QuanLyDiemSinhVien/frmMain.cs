using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Common;
using QuanLyDiemSinhVien.MonHocGUI;
using QuanLyDiemSinhVien.DangNhapGUI;
using DevExpress.LookAndFeel;
using QuanLyDiemSinhVien.LopGUI;
using QuanLyDiemSinhVien.NhapDiemGUI;
using QuanLyDiemSinhVien.Lop_SinhVienGUI;
using QuanLyDiemSinhVien.HocPhiGUI;
using QuanLyDiemSinhVien.TaoTaiKhoanGUI;
using QuanLyDiemSinhVien.BaoCaoGUI;

namespace QuanLyDiemSinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Constructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region UI Event

        private void frmMain_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SkinName = "Office 2016 Colorful";
            //UserLookAndFeel.Default.SkinMaskColor = Color.Blue;
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            btnTaoTaiKhoan.Enabled = false;
            btnMonHoc.Enabled = false;
            btnLop.Enabled = false;
            btnSinhVien.Enabled = false;
            btnNhapDiem.Enabled = false;
            btnHocPhi.Enabled = false;
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
                f.PrintInfoLoginEvent += new frmDangNhap.PrintInfoLoginHandler(ShowStatusBar);
            }

        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc frmMonHoc = new frmMonHoc();
                frmMonHoc.MdiParent = this;
                frmMonHoc.Show();
            }
        }

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }       
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop_SinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmLop_SinhVien f = new frmLop_SinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }        

        private void btnNhapDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }
        #endregion

        #region Utilities
        private void ShowStatusBar(string x_strMaGV, string x_strHoTen, string x_strNhom)
        {
            MAGV.Caption = string.Format("MAGV: {0}", x_strMaGV);
            HOTEN.Caption = string.Format("| HOTEN: {0}", x_strHoTen);
            NHOM.Caption = string.Format("| NHOM: {0}", x_strNhom);
            ToggleButton(x_strNhom.Trim());
        }

        private void ToggleButton(string x_strNhomQuyen)
        {
            if (x_strNhomQuyen.Equals("PGV"))
            {
                btnMonHoc.Enabled = true;
                btnLop.Enabled = true;
                btnSinhVien.Enabled = true;
                btnNhapDiem.Enabled = true;
                btnHocPhi.Enabled = false;
                btnDangXuat.Enabled = true;
                btnDangNhap.Enabled = false;
                btnTaoTaiKhoan.Enabled = true;
                return;
            }

            if (x_strNhomQuyen.Equals("Khoa"))
            {
                btnMonHoc.Enabled = true;
                btnLop.Enabled = true;
                btnSinhVien.Enabled = true;
                btnNhapDiem.Enabled = true;
                btnHocPhi.Enabled = false;
                btnDangXuat.Enabled = true;
                btnDangNhap.Enabled = false;
                btnTaoTaiKhoan.Enabled = true;
                return;
            }

            if (x_strNhomQuyen.Equals("PKeToan"))
            {
                btnMonHoc.Enabled = false;
                btnLop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnNhapDiem.Enabled = false;
                btnHocPhi.Enabled = true;
                btnDangXuat.Enabled = true;
                btnDangNhap.Enabled = false;
                btnTaoTaiKhoan.Enabled = true;
                return;
            }
        }
        #endregion

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Data.Con != null && Data.Con.State == ConnectionState.Open)
                {
                    Data.Con.Close();
                }
                ShowStatusBar("", "", "");
                Common.Data.m_strServerName = "";
                Common.Data.m_strLogin = "";
                Common.Data.m_strPassword = "";

                Common.Data.m_strLoginDN = "";
                Common.Data.m_strPasswordDN = "";

                Common.Data.m_strMaGV = "";
                Common.Data.m_strGroup = "";
                Common.Data.m_strHoten = "";

                Common.Data.m_nKhoa = 0;

                btnDangNhap.Enabled = true;
                btnDangXuat.Enabled = false;
                btnTaoTaiKhoan.Enabled = false;
                btnMonHoc.Enabled = false;
                btnLop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnNhapDiem.Enabled = false;
                btnHocPhi.Enabled = false;

                MessageBox.Show("Đăng xuất thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
                f.PrintInfoLoginEvent += new frmDangNhap.PrintInfoLoginHandler(ShowStatusBar);
            }
            catch
            {
                MessageBox.Show("Đăng xuất thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btn_InDSSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Xrm_DanhSachSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                Xrm_DanhSachSinhVien f = new Xrm_DanhSachSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}