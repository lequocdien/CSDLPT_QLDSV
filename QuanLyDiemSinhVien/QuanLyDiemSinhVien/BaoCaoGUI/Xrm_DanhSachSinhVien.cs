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
    public partial class Xrm_DanhSachSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public Xrm_DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void Xrm_DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Common.Data.bds_CNTT_VT; 
            cmbKhoa.DisplayMember = "TENKHOA";//tên field chứa dữ liệu ta chọn
            cmbKhoa.ValueMember = "TENSERVER";//tên field chứa dữ liệu tương ứng với item ta chọn
            cmbKhoa.SelectedIndex = Common.Data.m_nKhoa;//vị trí item hiện tại
            if(Common.Data.m_strGroup.Equals("PGV") == false)
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Common.Data.m_strServerName = cmbKhoa.SelectedValue.ToString();
            }
            if (cmbKhoa.SelectedIndex != Common.Data.m_nKhoa)
            {
                Common.Data.m_strLogin = Common.Constant.REMOTE_LOGIN;
                Common.Data.m_strPassword = Common.Constant.REMOTE_PASSWORD;
            }
            else
            {
                Common.Data.m_strLogin = Common.Data.m_strLoginDN;
                Common.Data.m_strPassword = Common.Data.m_strPasswordDN;
            }
            if (BUL.DangNhapBUL.KiemTraKetNoi() == false)
            {
                MessageBox.Show("Kết nối về khoa mới thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(BUL.LopBUL.LoadLop() == null)
                {
                    return;
                }
                cmbTenLop.DataSource = BUL.LopBUL.LoadLop();
                cmbTenLop.DisplayMember = "TENLOP";
                cmbTenLop.ValueMember = "MALOP";
                cmbTenLop.SelectedIndex = 0;
            }
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string strMaLop = txtMaLop.Text;
            Xtrp_DanhSachSinhVien rpt = new Xtrp_DanhSachSinhVien(strMaLop);
            rpt.xrLabel_Lop.Text = "Lớp: "+cmbTenLop.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}