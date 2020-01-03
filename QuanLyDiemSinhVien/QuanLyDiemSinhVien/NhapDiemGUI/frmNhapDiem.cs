using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using BUL;
using DTO;
using Common;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDiemSinhVien.NhapDiemGUI
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private List<BangDiemSinhVienDTO> m_lstBangDiem;
        private string m_strMaLop;
        private string m_strMaMonHoc;
        private int m_nLanThi;
        private Action m_objAction;
        BindingSource m_bdBangDiem = new BindingSource();
        #endregion

        #region Constructor
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        #endregion

        #region UI Event
        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            cbxKhoa.DataSource = NhapDiemBUL.LoadPhanManh();
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

            ToggleButtonBatDau(true);
            btnNhapDiem.Enabled = false;
            btnSuaDiem.Enabled = false;
            btnChonLai.Enabled = false;
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.m_strServerName = ((PhanManhDTO)cbxKhoa.SelectedItem).TenServer;
            if (cbxKhoa.SelectedIndex == Data.m_nKhoa)
            {
                Data.m_strLogin = Data.m_strLoginDN;
                Data.m_strPassword = Data.m_strPasswordDN;
            }
            else
            {
                Data.m_strLogin = Constant.REMOTE_LOGIN;
                Data.m_strPassword = Constant.REMOTE_PASSWORD;
            }

            if (NhapDiemBUL.ChangeServer() == false)
            {
                MessageBox.Show("Kết nối khoa mới thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxKhoa.SelectedIndex = Data.m_nKhoa;
                return;
            }

            InitalizeComboBoxLop();
            InitalizeComboBoxMonHoc();
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

        private void cbxLanThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nLanThi = cbxLanThu.SelectedIndex + 1;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            ToggleButtonBatDau(false);

            m_objAction = CanInsertOrUpdateBangDiem();

            if (m_objAction == Action.Unknown)
            {
                //TODO:
                return;
            }

            if (m_objAction == Action.Insert)
            {
                btnNhapDiem.Enabled = true;
                btnSuaDiem.Enabled = false;
            }
            else if (m_objAction == Action.Update)
            {
                btnNhapDiem.Enabled = false;
                btnSuaDiem.Enabled = true;
            }
            else if (m_objAction == Action.NotAllow)
            {
                btnNhapDiem.Enabled = false;
                btnSuaDiem.Enabled = false;
            }

            InitializeDataGridView();
        }

        private void dgvNhapDiem_CellValidating(object sender, DataGridViewCellValidatingEventArgs x_objEventArgs)
        {
            try
            {
                float fValue;
                if (x_objEventArgs.ColumnIndex == 2)
                {
                    if (!float.TryParse(x_objEventArgs.FormattedValue.ToString(), out fValue) || fValue < 0 || fValue > 10)
                    {
                        MessageBox.Show("Điểm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvNhapDiem.CancelEdit();
                        return;
                    }
                }
                return;
            }
            catch
            {

            }
        }

        private void btnChonLai_Click(object sender, EventArgs e)
        {
            SetGUI(true);
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            string strMaMonHoc = cbxMonHoc.SelectedValue.ToString().Trim();
            int nLan = cbxLanThu.SelectedIndex + 1;
            if (NhapDiemBUL.InsertBangDiemSinhVien(m_lstBangDiem, strMaMonHoc, nLan) == false)
            {
                MessageBox.Show("Nhập điểm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Nhập điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetGUI(true);
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            string strMaMonHoc = cbxMonHoc.SelectedValue.ToString().Trim();
            int nLan = cbxLanThu.SelectedIndex + 1;
            if (NhapDiemBUL.UpdateBangDiemSinhVien(m_lstBangDiem, strMaMonHoc, nLan) == false)
            {
                MessageBox.Show("Cập nhật điểm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetGUI(true);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            ToggleButtonBatDau(false);
            InitializeDataGridView();
            MessageBox.Show("Tải lại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Utilities
        private void InitalizeComboBoxLop()
        {
            cbxLop.DataSource = NhapDiemBUL.LoadLop();
            cbxLop.DisplayMember = "TENLOP";
            cbxLop.ValueMember = "MALOP";
            cbxLop.SelectedIndex = 0;
        }

        private void InitalizeComboBoxMonHoc()
        {
            cbxMonHoc.DataSource = NhapDiemBUL.LoadMonHoc();
            cbxMonHoc.DisplayMember = "TenMH";
            cbxMonHoc.ValueMember = "MaMH";
            cbxMonHoc.SelectedIndex = 0;
        }

        private void InitalizeComboBoxLanThi()
        {
            int nSoLanThi = NhapDiemBUL.LoadLanThi(m_strMaMonHoc, m_strMaLop).Count;

            if (nSoLanThi == 0)
            {
                //Không có lần thi nào
                cbxLanThu.Items.Clear();
                cbxLanThu.Items.Add("Lần 1");
                cbxLanThu.SelectedIndex = 0;
            }

            if (nSoLanThi == 1 || nSoLanThi == 2)
            {
                // Có 1 lần thi hoặc 2 lần thi
                cbxLanThu.Items.Clear();
                cbxLanThu.Items.Add("Lần 1");
                cbxLanThu.Items.Add("Lần 2");
                cbxLanThu.SelectedIndex = 0;
            }
        }

        private void InitializeDataGridView()
        {
            string strMaLop = ((LopDTO)cbxLop.SelectedItem).MALOP.Trim();
            string strMaMonHoc = ((MonHocDTO)cbxMonHoc.SelectedItem).MaMH.Trim();
            int nLanThi = cbxLanThu.SelectedIndex + 1;

            m_lstBangDiem = NhapDiemBUL.LoadBangDiemSinhVien(strMaLop, strMaMonHoc, nLanThi);
            m_bdBangDiem.DataSource = m_lstBangDiem;
            dgvNhapDiem.DataSource = m_bdBangDiem;

            if (m_objAction == Action.NotAllow)
            {
                dgvNhapDiem.Columns["colDiem"].ReadOnly = true;
            }
            else
            {
                dgvNhapDiem.Columns["colDiem"].ReadOnly = false;
            }
        }

        private Action CanInsertOrUpdateBangDiem()
        {
            List<string> lstLanThi = NhapDiemBUL.LoadLanThi(m_strMaMonHoc, m_strMaLop);
            if (lstLanThi == null)
            {
                //TODO:
                return Action.Unknown;
            }

            int nSoLanThi = lstLanThi.Count;
            if (m_nLanThi == 1 && nSoLanThi == 0)
            {
                return Action.Insert;
            }

            if (m_nLanThi == 1 && nSoLanThi == 1)
            {
                return Action.Update;
            }

            if (m_nLanThi == 1 && nSoLanThi == 2)
            {
                return Action.NotAllow;
            }

            if (m_nLanThi == 2 && nSoLanThi == 1)
            {
                return Action.Insert;
            }

            if (m_nLanThi == 2 && nSoLanThi == 2)
            {
                return Action.Update;
            }
            return Action.Unknown;
        }

        private void SetGUI(bool x_bIsEnableBatDau)
        {
            ToggleButtonBatDau(x_bIsEnableBatDau);
            btnNhapDiem.Enabled = !x_bIsEnableBatDau;
            btnSuaDiem.Enabled = !x_bIsEnableBatDau;
            btnPhucHoi.Enabled = !x_bIsEnableBatDau;
            dgvNhapDiem.Rows.Clear();
        }

        private void ToggleButtonBatDau(bool x_bIsEnable)
        {
            if (Data.m_strGroup.ToUpper().Equals("PKETOAN") || Data.m_strGroup.ToUpper().Equals("KHOA"))
            {
                cbxKhoa.Enabled = false;
            }
            else if (Data.m_strGroup.Equals("PGV"))
            {
                cbxKhoa.Enabled = x_bIsEnable;
            }
            cbxLop.Enabled = x_bIsEnable;
            cbxMonHoc.Enabled = x_bIsEnable;
            cbxLanThu.Enabled = x_bIsEnable;
            btnBatDau.Enabled = x_bIsEnable;
            btnChonLai.Enabled = !x_bIsEnable;

            //pnlPrepareNhapDiem.ForeColor = x_bIsEnable ? Color.White : Color.Silver;
            lblKhoa.ForeColor = x_bIsEnable ? Color.White : Color.Silver;
            cbxKhoa.ForeColor = x_bIsEnable ? Color.White : Color.Silver;
            lblLop.ForeColor = x_bIsEnable ? Color.White : Color.Silver;
            cbxLop.ForeColor = x_bIsEnable ? Color.White : Color.Silver;
            lblMonHoc.ForeColor = x_bIsEnable ? Color.White : Color.Silver;
            cbxMonHoc.ForeColor = x_bIsEnable ? Color.White : Color.Silver;
            lblLanThi.ForeColor = x_bIsEnable ? Color.White : Color.Silver;
            btnBatDau.ForeColor = x_bIsEnable ? Color.Black : Color.Silver;
        }
        #endregion
    }

    public enum Action
    {
        Insert,
        Update,
        NotAllow,
        Unknown
    }
}