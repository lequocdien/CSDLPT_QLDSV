using BUL;
using DevExpress.XtraReports.UI;
using QuanLyDiemSinhVien.ReportGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.InputGUI
{
    public partial class frmInputBangDiemMonHoc : Form
    {
        public frmInputBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string strMaMH = txtMaMonHoc.Text.Trim();
            string strMaLop = txtMaLop.Text.Trim();
            int nLanThi;
            int.TryParse(txtLanThi.Text.Trim(), out nLanThi);

            rptBangDiemMonHoc objReport = new rptBangDiemMonHoc();
            objReport.lblMonHoc.Text = BangDiemMonHocBUL.GetTenMonHoc(strMaMH);
            objReport.lblLop.Text = BangDiemMonHocBUL.GetTenLop(strMaLop);
            objReport.lblLanThi.Text = nLanThi.ToString();
            objReport.DataSource = BangDiemMonHocBUL.LoadBangDiemMonHoc(strMaLop, strMaMH, nLanThi);

            ReportPrintTool tool = new ReportPrintTool(objReport);
            tool.ShowPreview();
        }
    }
}
