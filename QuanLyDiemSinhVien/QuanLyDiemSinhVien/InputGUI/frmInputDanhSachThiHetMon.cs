using BUL;
using DevExpress.XtraReports.UI;
using QuanLyDiemSinhVien.ReportGUI;
using System;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.InputGUI
{
    public partial class frmInputDanhSachThiHetMon : Form
    {
        #region Constructor
        public frmInputDanhSachThiHetMon()
        {
            InitializeComponent();
        }
        #endregion

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            IFormatProvider culture = new System.Globalization.CultureInfo("vi-VI", true);

            string strMaLop = txtMaLop.Text.Trim();
            string strMaMonHoc = txtMaMonHoc.Text.Trim();
            string strNgayThi = dtpNgayThi.Value.GetDateTimeFormats(culture)[0];
            int nLanThi;
            int.TryParse(txtLanThi.Text.Trim(), out nLanThi);

            rptDanhSachThiHetMon objReport = new rptDanhSachThiHetMon();
            objReport.lblTenLop.Text = DanhSachThiHetMonBUL.GetTenLop(strMaLop);
            objReport.lblTenMonHoc.Text = DanhSachThiHetMonBUL.GetTenMonHoc(strMaMonHoc);
            objReport.lblNgayThi.Text = strNgayThi.ToString();
            objReport.DataSource = DanhSachThiHetMonBUL.LoadDanhSachThiHetMon(strMaLop, strMaMonHoc, nLanThi);
            ReportPrintTool objTool = new ReportPrintTool(objReport);
            objTool.ShowPreview();
        }
    }
}
