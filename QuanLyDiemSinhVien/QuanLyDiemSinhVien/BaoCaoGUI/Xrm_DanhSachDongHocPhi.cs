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
using DevExpress.XtraReports.UI;

namespace QuanLyDiemSinhVien.BaoCaoGUI
{
    public partial class Xrm_DanhSachDongHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public Xrm_DanhSachDongHocPhi()
        {
            InitializeComponent();
        }

        private void Xrm_DanhSachDongHocPhi_Load(object sender, EventArgs e)
        {
            cmbMaLop.DataSource = BUL.HocPhiBUL.LoadMaLop();
            cmbMaLop.DisplayMember = "MALOP";
            cmbMaLop.SelectedIndex = 0;
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string strMaLop = cmbMaLop.Text.Trim();
            if(txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strNienKhoa = txtNienKhoa.Text.Trim();
            int HocKy;
            if (txtHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Học kỳ không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(this.txtHocKy.Text, out HocKy) == false)
            {
                MessageBox.Show("Học kỳ phải là số", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Xtrp_DanhSachDongHocPhi rpt = new Xtrp_DanhSachDongHocPhi(strMaLop, strNienKhoa, HocKy);
            rpt.xrLabel_MaLop.Text = "Mã lớp: " + strMaLop;
            rpt.xrLabel_NienKhoa.Text = "Niên khóa: " + strNienKhoa;
            rpt.xrLabel_HocKy.Text = "Học kỳ: " + HocKy;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}