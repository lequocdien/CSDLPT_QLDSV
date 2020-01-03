using BUL;
using Common;
using DevExpress.XtraReports.UI;
using DTO;
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
        private string m_strMaLop;
        private string m_strMaMonHoc;

        public frmInputBangDiemMonHoc()
        {
            InitializeComponent();
        }

        #region Event UI
        private void frmInputBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            cbxKhoa.DataSource = BangDiemMonHocBUL.LoadPhanManh();
            cbxKhoa.DisplayMember = "TenKhoa";
            cbxKhoa.ValueMember = "TenServer";
            cbxKhoa.SelectedIndex = Data.m_nKhoa;

            if (Data.m_strGroup.ToUpper().Equals("PKETOAN") || Data.m_strGroup.ToUpper().Equals("KHOA"))
            {
                cbxKhoa.Enabled = false;
            }
            else if (Data.m_strGroup.Equals("PGV"))
            {
                cbxKhoa.Enabled = true;
            }
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.m_strServerName = ((PhanManhDTO)cbxKhoa.SelectedItem).TenServer.Trim();
            if (cbxKhoa.SelectedIndex != Data.m_nKhoa)
            {
                Data.m_strLogin = Constant.REMOTE_LOGIN;
                Data.m_strPassword = Constant.REMOTE_PASSWORD;
            }
            else
            {
                Data.m_strLogin = Data.m_strLoginDN;
                Data.m_strPassword = Data.m_strPasswordDN;
            }

            if (DanhSachThiHetMonBUL.ChangeServer() == false)
            {
                MessageBox.Show("Kết nối khoa mới thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitalizeComboBoxMonHoc();
            InitalizeComboBoxLop();
            InitalizeComboBoxLanThi();
        }

        private void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_strMaLop = ((LopDTO)cbxLop.SelectedItem).MALOP.Trim();
            InitalizeComboBoxLanThi();
        }

        private void cbxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_strMaMonHoc = ((MonHocDTO)cbxMonHoc.SelectedItem).MaMH.Trim();
            InitalizeComboBoxLanThi();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string strMaLop = ((LopDTO)cbxLop.SelectedItem).MALOP;
            string strMaMonHoc = ((MonHocDTO)cbxMonHoc.SelectedItem).MaMH;
            string strLanThi = cbxLanThi.Text.Trim();

            if (string.IsNullOrWhiteSpace(strLanThi) || strMaLop == null || strMaLop == null)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nLanThi;
            int.TryParse(strLanThi, out nLanThi);

            rptBangDiemMonHoc objReport = new rptBangDiemMonHoc();
            objReport.lblLop.Text = BangDiemMonHocBUL.GetTenLop(strMaLop);
            objReport.lblMonHoc.Text = BangDiemMonHocBUL.GetTenMonHoc(strMaMonHoc);
            objReport.lblLanThi.Text = strLanThi;
            objReport.DataSource = BangDiemMonHocBUL.LoadBangDiemMonHoc(strMaLop, strMaMonHoc, nLanThi);
            ReportPrintTool objTool = new ReportPrintTool(objReport);
            objTool.ShowPreview();
        }
        #endregion

        #region Ultilities
        private void InitalizeComboBoxLop()
        {
            cbxLop.DataSource = BangDiemMonHocBUL.LoadLop();
            cbxLop.DisplayMember = "TENLOP";
            cbxLop.ValueMember = "MALOP";
            cbxLop.SelectedIndex = 0;
        }

        private void InitalizeComboBoxMonHoc()
        {
            cbxMonHoc.DataSource = BangDiemMonHocBUL.LoadMonHoc();
            cbxMonHoc.DisplayMember = "TenMH";
            cbxMonHoc.ValueMember = "MaMH";
            cbxMonHoc.SelectedIndex = 0;
        }

        private void InitalizeComboBoxLanThi()
        {
            cbxLanThi.Text = string.Empty;
            cbxLanThi.DataSource = BangDiemMonHocBUL.LoadLanThi(m_strMaMonHoc, m_strMaLop);
        }
        #endregion


    }
}
