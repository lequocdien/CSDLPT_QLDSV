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
    public partial class frmInputBangDiemSinhVien : Form
    {
        private List<SinhVienDTO> m_lstSinhVien;

        public frmInputBangDiemSinhVien()
        {
            InitializeComponent();
        }

        #region UI Event
        private void frmInputPhieuDiem_Load(object sender, EventArgs e)
        {
            cbxKhoa.DataSource = BangDiemSinhVienBUL.LoadPhanManh();
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

            InitalizeTextBoxMaSinhVien();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string strMaSinhVien = txtMaSV.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(strMaSinhVien))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < m_lstSinhVien.Count; i++)
            {
                if (strMaSinhVien.Equals(m_lstSinhVien[i].MASV.ToUpper().Trim()))
                {
                    rptBangDiemSinhVien objReport = new rptBangDiemSinhVien();
                    objReport.lblMaSV.Text = strMaSinhVien.ToUpper();
                    objReport.lblHoVaTen.Text = BangDiemSinhVienBUL.GetHoTen(strMaSinhVien).ToUpper();
                    objReport.lblLop.Text = BangDiemSinhVienBUL.GetMaLop(strMaSinhVien).ToUpper();
                    objReport.DataSource = BangDiemSinhVienBUL.LoadPhieuDiem(strMaSinhVien);

                    ReportPrintTool tool = new ReportPrintTool(objReport);
                    tool.ShowPreview();

                    return;
                }
            }

            MessageBox.Show("Mã sinh viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Ultilities
        private void InitalizeTextBoxMaSinhVien()
        {
            m_lstSinhVien = BangDiemSinhVienBUL.LoadSinhVien();
            AutoCompleteStringCollection objacs = new AutoCompleteStringCollection();
            for (int i = 0; i < m_lstSinhVien.Count; i++)
            {
                objacs.Add(m_lstSinhVien[i].MASV.Trim());
            }
            txtMaSV.AutoCompleteCustomSource = objacs;
        }
        #endregion
    }
}
