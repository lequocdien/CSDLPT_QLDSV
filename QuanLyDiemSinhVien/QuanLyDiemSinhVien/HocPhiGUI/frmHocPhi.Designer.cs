namespace QuanLyDiemSinhVien.HocPhiGUI
{
    partial class frmHocPhi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhapDiem = new DevExpress.XtraEditors.SimpleButton();
            this.pnlPrepareNhapDiem = new System.Windows.Forms.Panel();
            this.gbxNhapDiemCho = new System.Windows.Forms.GroupBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.dgvNhapDiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlPrepareNhapDiem.SuspendLayout();
            this.gbxNhapDiemCho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Controls.Add(this.btnPhucHoi);
            this.panel1.Controls.Add(this.btnNhapDiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 86);
            this.panel1.TabIndex = 4;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Appearance.Options.UseFont = true;
            this.btnTaiLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiLai.ImageOptions.SvgImage")));
            this.btnTaiLai.Location = new System.Drawing.Point(206, 12);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(188, 61);
            this.btnTaiLai.TabIndex = 0;
            this.btnTaiLai.Text = "Tải lại";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoi.Appearance.Options.UseFont = true;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Location = new System.Drawing.Point(400, 12);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(188, 61);
            this.btnPhucHoi.TabIndex = 0;
            this.btnPhucHoi.Text = "Phục hồi";
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.Appearance.Options.UseFont = true;
            this.btnNhapDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhapDiem.ImageOptions.SvgImage")));
            this.btnNhapDiem.Location = new System.Drawing.Point(12, 12);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(188, 61);
            this.btnNhapDiem.TabIndex = 0;
            this.btnNhapDiem.Text = "Ghi";
            // 
            // pnlPrepareNhapDiem
            // 
            this.pnlPrepareNhapDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlPrepareNhapDiem.Controls.Add(this.gbxNhapDiemCho);
            this.pnlPrepareNhapDiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrepareNhapDiem.ForeColor = System.Drawing.Color.White;
            this.pnlPrepareNhapDiem.Location = new System.Drawing.Point(0, 86);
            this.pnlPrepareNhapDiem.Name = "pnlPrepareNhapDiem";
            this.pnlPrepareNhapDiem.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPrepareNhapDiem.Size = new System.Drawing.Size(549, 662);
            this.pnlPrepareNhapDiem.TabIndex = 7;
            // 
            // gbxNhapDiemCho
            // 
            this.gbxNhapDiemCho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbxNhapDiemCho.Controls.Add(this.txtMaLop);
            this.gbxNhapDiemCho.Controls.Add(this.txtHoTen);
            this.gbxNhapDiemCho.Controls.Add(this.cbxKhoa);
            this.gbxNhapDiemCho.Controls.Add(this.label2);
            this.gbxNhapDiemCho.Controls.Add(this.label1);
            this.gbxNhapDiemCho.Controls.Add(this.lblKhoa);
            this.gbxNhapDiemCho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxNhapDiemCho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNhapDiemCho.ForeColor = System.Drawing.Color.White;
            this.gbxNhapDiemCho.Location = new System.Drawing.Point(20, 20);
            this.gbxNhapDiemCho.Name = "gbxNhapDiemCho";
            this.gbxNhapDiemCho.Size = new System.Drawing.Size(509, 622);
            this.gbxNhapDiemCho.TabIndex = 5;
            this.gbxNhapDiemCho.TabStop = false;
            this.gbxNhapDiemCho.Text = "Đóng học phí cho: ";
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.BackColor = System.Drawing.Color.White;
            this.cbxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxKhoa.Enabled = false;
            this.cbxKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.IntegralHeight = false;
            this.cbxKhoa.Location = new System.Drawing.Point(168, 95);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(320, 36);
            this.cbxKhoa.TabIndex = 4;
            // 
            // lblKhoa
            // 
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.ForeColor = System.Drawing.Color.White;
            this.lblKhoa.Location = new System.Drawing.Point(7, 94);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(155, 36);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Mã sinh viên:";
            this.lblKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvNhapDiem
            // 
            this.dgvNhapDiem.AllowUserToAddRows = false;
            this.dgvNhapDiem.AllowUserToDeleteRows = false;
            this.dgvNhapDiem.AllowUserToResizeRows = false;
            this.dgvNhapDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvNhapDiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhapDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapDiem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNhapDiem.Location = new System.Drawing.Point(549, 86);
            this.dgvNhapDiem.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dgvNhapDiem.MultiSelect = false;
            this.dgvNhapDiem.Name = "dgvNhapDiem";
            this.dgvNhapDiem.RowHeadersVisible = false;
            this.dgvNhapDiem.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvNhapDiem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhapDiem.RowTemplate.Height = 28;
            this.dgvNhapDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapDiem.Size = new System.Drawing.Size(827, 662);
            this.dgvNhapDiem.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ và tên: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(168, 168);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(320, 36);
            this.txtHoTen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã lớp: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(168, 234);
            this.txtMaLop.Multiline = true;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(320, 36);
            this.txtMaLop.TabIndex = 5;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 748);
            this.Controls.Add(this.dgvNhapDiem);
            this.Controls.Add(this.pnlPrepareNhapDiem);
            this.Controls.Add(this.panel1);
            this.Name = "frmHocPhi";
            this.Text = "Học phí";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            this.panel1.ResumeLayout(false);
            this.pnlPrepareNhapDiem.ResumeLayout(false);
            this.gbxNhapDiemCho.ResumeLayout(false);
            this.gbxNhapDiemCho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
        private DevExpress.XtraEditors.SimpleButton btnPhucHoi;
        private DevExpress.XtraEditors.SimpleButton btnNhapDiem;
        private System.Windows.Forms.Panel pnlPrepareNhapDiem;
        private System.Windows.Forms.GroupBox gbxNhapDiemCho;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.DataGridView dgvNhapDiem;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}