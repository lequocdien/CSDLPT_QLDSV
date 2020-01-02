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
            qldsvDataSet_PKeToan1.EnforceConstraints = false;
            this.sP_InDanhSachDongHocPhiTableAdapter.Fill(qldsvDataSet_PKeToan1.SP_InDanhSachDongHocPhi, MaLop, NienKhoa, HocKy);
        }

    }
}
