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
using QuanLyDiemSinhVien.TaoTaiKhoanGUI;

namespace QuanLyDiemSinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Constructor
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SkinName = "Office 2016 Colorful";
            //UserLookAndFeel.Default.SkinMaskColor = Color.Blue;
        }
        #endregion

        #region UI Event
        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMonHoc frmMonHoc = new frmMonHoc();
            frmMonHoc.MdiParent = this;
            frmMonHoc.Show();
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Show();
            f.PrintInfoLoginEvent += new frmDangNhap.PrintInfoLoginHandler(ShowStatusBar);
        }

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLop f = new frmLop();
            f.MdiParent = this;
            f.Show();
        }

        private void btnNhapDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhapDiem f = new frmNhapDiem();
            f.MdiParent = this;
            f.Show();
        }
        #endregion

        public void ShowStatusBar(string x_strMaGV, string x_strHoTen, string x_strNhom)
        {
            MAGV.Caption = string.Format("MAGV: {0}", x_strMaGV);
            HOTEN.Caption = string.Format("| HOTEN: {0}", x_strHoTen);
            NHOM.Caption = string.Format("| NHOM: {0}", x_strNhom);
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLop_SinhVien f = new frmLop_SinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void btnTaoLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTaoTaiKhoan f = new frmTaoTaiKhoan();
            f.MdiParent = this;
            f.Show();
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
                MessageBox.Show("Đăng xuất thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Đăng xuất thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}