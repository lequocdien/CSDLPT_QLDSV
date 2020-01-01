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
        private List<PhanManhDTO> m_lstPhanManh;
        private List<LopDTO> m_lstLop;
        private List<MonHocDTO> m_lstMonHoc;
        private List<BangDiemSinhVienDTO> m_lstBangDiem;
        private string m_strMaKhoa;
        private string m_strMaLop;
        private string m_strMaMonHoc;
        private int m_nLanThi;
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
            ToggleComponent(true);
            InitializeListPhanManh();
            InitializeListMonHoc();
            InitializeListLop();
            InitializeCombox();
            cbxKhoa.SelectedItem = Data.m_nKhoa;
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((PhanManhDTO)cbxKhoa.SelectedItem).TenPhanManh.Equals(Constant.PUBLICATION_NAME_CNTT))
            {
                m_strMaKhoa = "CNTT";
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
            }
            else if (((PhanManhDTO)cbxKhoa.SelectedItem).TenPhanManh.Equals(Constant.PUBLICATION_NAME_VT))
            {
                m_strMaKhoa = "VT";
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
            }

            if (NhapDiemBUL.ChangeSever() == false)
            {
                MessageBox.Show("Kết nối Server mới không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxKhoa.SelectedIndex = Data.m_nKhoa;
                return;
            }

            InitializeListMonHoc();
            InitializeListLop();
            InitializeCombox();
        }

        private void cbxLopAndcbxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxLop.Items.Count == 0 || cbxMonHoc.Items.Count == 0)
            {
                return;
            }
            m_strMaMonHoc = ((MonHocDTO)cbxMonHoc.SelectedItem).MaMH.ToString();
            m_strMaLop = ((LopDTO)cbxLop.SelectedItem).MALOP.ToString();

            int nSoLanThi = NhapDiemBUL.CountSoLanThi(m_strMaMonHoc, m_strMaLop);
            if(nSoLanThi == -1)
            {
                return;
            }

            if(nSoLanThi == 0)
            {
                //Initialize ComboBox LAN THI THU
                cbxLanThu.Items.Clear();
                cbxLanThu.Items.Add("Lần 1");
                cbxLanThu.SelectedIndex = 0;
            }

            if (nSoLanThi == 1)
            {
                //Initialize ComboBox LAN THI THU
                cbxLanThu.Items.Clear();
                cbxLanThu.Items.Add("Lần 1");
                cbxLanThu.Items.Add("Lần 2");
                cbxLanThu.SelectedIndex = 0;
            }

            if (nSoLanThi == 2)
            {
                //Initialize ComboBox LAN THI THU
                cbxLanThu.Items.Clear();
                cbxLanThu.Items.Add("Lần 1");
                cbxLanThu.Items.Add("Lần 2");
                cbxLanThu.SelectedIndex = 0;
            }
        }

        private void cbxLanThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nLanThi = cbxLanThu.SelectedIndex + 1;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            ToggleButtonBatDau(false);

            InitializeListBangDiem();

            int nUpdateOrInsert = CanInsertOrUpdateBangDiem();
            if (nUpdateOrInsert == -1)
            {
                return;
            }
            
            if(nUpdateOrInsert == 0)
            {
                btnNhapDiem.Enabled = true;
                btnSuaDiem.Enabled = false;
            }
            else if(nUpdateOrInsert == 1)
            {
                btnNhapDiem.Enabled = false;
                btnSuaDiem.Enabled = true;
            }
            else if(nUpdateOrInsert == 2)
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
                if(x_objEventArgs.ColumnIndex == 2)
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
            ToggleComponent(true);
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
            ToggleComponent(true);
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
            ToggleComponent(true);
        }
        #endregion

        #region Utilities
        private void InitializeListPhanManh()
        {
            m_lstPhanManh = new List<PhanManhDTO>();
            DataTable dtPhanManh = DangNhapBUL.LoadPhanManh();
            if (dtPhanManh == null || dtPhanManh.Rows.Count == 0)
            {
                return;
            }
            for (int i = 0; i < dtPhanManh.Rows.Count; i++)
            {
                if (dtPhanManh.Rows[i][0].ToString().Equals(Constant.PUBLICATION_NAME_KT))
                {
                    continue;
                }
                PhanManhDTO objPhanManh = new PhanManhDTO();
                objPhanManh.TenPhanManh = dtPhanManh.Rows[i][0].ToString();
                objPhanManh.TenServer = dtPhanManh.Rows[i][1].ToString();
                m_lstPhanManh.Add(objPhanManh);
            }
        }

        private void InitializeListLop()
        {
            m_lstLop = LopBUL.LoadLop();
        }

        private void InitializeListMonHoc()
        {
            m_lstMonHoc = MonHocBUL.LoadMonHoc();
        }

        private void InitializeListBangDiem()
        {
            string strMaLop = ((LopDTO)cbxLop.SelectedItem).MALOP.Trim();
            string strMaMonHoc = ((MonHocDTO)cbxMonHoc.SelectedItem).MaMH.Trim();
            int nLanThi = cbxLanThu.SelectedIndex + 1;

            //TODO: Nên để hàm LoadBangDiemSinhVien() vào try catch
            SqlDataReader objReader = NhapDiemBUL.LoadBangDiemSinhVien(strMaLop, strMaMonHoc, nLanThi);
            if (objReader == null)
            {
                MessageBox.Show("Không thể load bảng điểm");
                return;
            }

            m_lstBangDiem = new List<BangDiemSinhVienDTO>();
            while (objReader.Read())
            {
                BangDiemSinhVienDTO objDiemSV = new BangDiemSinhVienDTO();
                objDiemSV.MaSinhVien = objReader[0].ToString();
                objDiemSV.HoTen = objReader[1].ToString();
                objDiemSV.Diem = Convert.ToSingle(objReader[2]);
                m_lstBangDiem.Add(objDiemSV);
            }
        }

        private void InitializeCombox()
        {
            //Initialize ComboBox KHOA
            cbxKhoa.DataSource = m_lstPhanManh;
            cbxKhoa.DisplayMember = "TenPhanManh";
            cbxKhoa.ValueMember = "TenServer";

            if (Data.m_strGroup.Equals("PKETOAN") || Data.m_strGroup.Equals("KHOA"))
            {
                cbxKhoa.Enabled = false;
            }
            else if (Data.m_strGroup.Equals("PGV"))
            {
                cbxKhoa.Enabled = true;
            }

            //Initialize ComboBox MON HOC
            cbxMonHoc.DataSource = m_lstMonHoc;
            cbxMonHoc.DisplayMember = "TENMH";
            cbxMonHoc.ValueMember = "MAMH";

            //Initialize ComboBox LOP
            cbxLop.DataSource = m_lstLop;
            cbxLop.DisplayMember = "TENLOP";
            cbxLop.ValueMember = "MALOP";

            cbxLop.SelectedIndex = 0;
            cbxMonHoc.SelectedIndex = 0;
            cbxLanThu.SelectedIndex = 0;
        }

        private void InitializeDataGridView()
        {
            m_bdBangDiem.DataSource = m_lstBangDiem;
            dgvNhapDiem.DataSource = m_bdBangDiem;
        }
         
        private int CanInsertOrUpdateBangDiem()
        {
            if (cbxLop.Items.Count == 0 || cbxMonHoc.Items.Count == 0)
            {
                return -1;
            }

            m_strMaMonHoc = ((MonHocDTO)cbxMonHoc.SelectedItem).MaMH.ToString();
            m_strMaLop = ((LopDTO)cbxLop.SelectedItem).MALOP.ToString();
            int nIndexCBXLanThu = cbxLanThu.SelectedIndex + 1;

            int nSoLanThi = NhapDiemBUL.CountSoLanThi(m_strMaMonHoc, m_strMaLop);
            if (nSoLanThi == -1)
            {
                return -1;
            }

            if (nIndexCBXLanThu == 1 && nSoLanThi == 0)
            {
                return 0;
            }

            if (nIndexCBXLanThu == 1 && nSoLanThi == 1)
            {
                return 1;
            }

            if (nIndexCBXLanThu == 1 && nSoLanThi == 2)
            {
                return 2;
            }
             
            if (nIndexCBXLanThu == 2 && nSoLanThi == 1)
            {
                return 0;
            }

            if (nIndexCBXLanThu == 2 && nSoLanThi == 2)
            {
                return 1;
            }
            return -1;
        }

        private void ToggleComponent(bool x_bIsEnableBatDau)
        {
            ToggleButtonBatDau(x_bIsEnableBatDau);
            btnNhapDiem.Enabled = !x_bIsEnableBatDau;
            btnSuaDiem.Enabled = !x_bIsEnableBatDau;
            btnPhucHoi.Enabled = !x_bIsEnableBatDau;
            dgvNhapDiem.Rows.Clear();
        }

        private void ToggleButtonBatDau(bool x_bIsEnable)
        {
            if (Data.m_strGroup.Equals("PKETOAN") || Data.m_strGroup.Equals("KHOA"))
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

        private void ToggleButtonPhucHoi(bool x_bIsEnable)
        {
            
        }

        #endregion
    }
}