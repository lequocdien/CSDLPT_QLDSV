using System.Windows.Forms;

namespace DTO
{
    public class BangDiemSinhVienDTO
    {
        #region Fields
        private float m_fDiem;
        #endregion

        #region Properties
        public string MaSinhVien { get; set; }
        public string MaMonHoc { get; set; }
        public int Lan { get; set; }
        public string HoTen { get; set; }
        public float Diem {
            get{
                return this.m_fDiem;
            }
            set
            {
                if(value < 0 || value > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.m_fDiem = value;
                }
            }
        }
        public string TenLop { get; set; }
        public string TenMonHoc { get; set; }
        #endregion
    }
}
