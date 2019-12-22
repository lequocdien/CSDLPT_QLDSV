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

namespace QuanLyDiemSinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SkinName = "Office 2016 Colorful";
            //UserLookAndFeel.Default.SkinMaskColor = Color.Blue;
        }

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
    }
}