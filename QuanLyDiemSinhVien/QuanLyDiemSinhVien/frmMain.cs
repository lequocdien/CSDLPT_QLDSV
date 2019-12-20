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
    }
}