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
    public partial class frmInputPhieuDiem : Form
    {
        public frmInputPhieuDiem()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string strMaSinhVien = txtMaSV.Text.Trim().ToUpper();

            rptPhieuDiem objReport = new rptPhieuDiem();
            objReport.lblMaSV.Text = strMaSinhVien;
            objReport.lblHoVaTen.Text = PhieuDiemBUL.GetHoTen(strMaSinhVien);
            objReport.lblLop.Text = PhieuDiemBUL.GetMaLop(strMaSinhVien);
            objReport.DataSource = PhieuDiemBUL.LoadPhieuDiem(strMaSinhVien);

            ReportPrintTool tool = new ReportPrintTool(objReport);
            tool.ShowPreview();
        }
    }
}
