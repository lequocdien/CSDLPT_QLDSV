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

namespace QuanLyDiemSinhVien.TaoTaiKhoanGUI
{
    public partial class frmGiangVien : DevExpress.XtraEditors.XtraForm
    {
        string MaGV = "";
        public frmGiangVien()
        {
            InitializeComponent();
        }

        public delegate void PrintInfoLoginHandler(string MaGV);

        public event PrintInfoLoginHandler PrintInfoLoginEvent;
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            dgvGiangVien.DataSource = BUL.GiangVienBUL.LoadGiangVien();
        }

        private void dgvGiangVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvGiangVien.RowCount; i++)
            {
                dgvGiangVien.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dgvGiangVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dgvGiangVien.Rows[dong].Cells[1].Value == null)
            {
                return;
            }
            MaGV = dgvGiangVien.Rows[dong].Cells[1].Value.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintInfoLoginEvent(MaGV);
            this.Close();
        }
    }
}