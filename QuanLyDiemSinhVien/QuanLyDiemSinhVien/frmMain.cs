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
    }
}