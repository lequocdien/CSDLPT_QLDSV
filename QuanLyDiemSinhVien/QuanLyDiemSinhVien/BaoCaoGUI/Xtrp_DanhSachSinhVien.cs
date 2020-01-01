using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyDiemSinhVien.BaoCaoGUI
{
    public partial class Xtrp_DanhSachSinhVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_DanhSachSinhVien(string MaLop)
        {
            InitializeComponent();
            qldsvDataSet1.EnforceConstraints = false;
            this.sP_InDanhSachSinhVienTableAdapter.Fill(qldsvDataSet1.SP_InDanhSachSinhVien, MaLop);
        }

    }
}
