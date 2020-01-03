using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyDiemSinhVien.BaoCaoGUI
{
    public partial class Xtrp_DanhSachDongHocPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_DanhSachDongHocPhi(string MaLop, string NienKhoa, int HocKy)
        {
            InitializeComponent();
            csdlpT_QLDSVDataSet_PKeToan1.EnforceConstraints = false;
            this.sP_InDanhSachDongHocPhiTableAdapter1.Connection.ConnectionString = Common.Data.connstr;
            this.sP_InDanhSachDongHocPhiTableAdapter1.Fill(csdlpT_QLDSVDataSet_PKeToan1.SP_InDanhSachDongHocPhi, MaLop, NienKhoa, HocKy);
        }

    }
}
