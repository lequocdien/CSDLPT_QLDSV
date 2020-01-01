using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.FormInput
{
    public partial class frmInputDanhSachThiHetMon : Form
    {
        #region Constructor
        public frmInputDanhSachThiHetMon()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        public delegate void InputReceivedHandler(string x_strMaLop, string x_strMaMonHoc, string x_strNgayThi, int x_nLanThi);

        public event InputReceivedHandler InputReceivedEvent;
        #endregion

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            InputReceivedEvent(txtMaLop.Text.Trim(), txtMaMonHoc.Text.Trim(), txtNgayThi.Text.Trim(), int.Parse(txtLanThi.Text.Trim()));
        }
    }
}
