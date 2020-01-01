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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.pnlPrepareNhapDiem = new System.Windows.Forms.Panel();
            this.gbxNhapDiemCho = new System.Windows.Forms.GroupBox();
            this.btnBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbxMaSinhVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.dgvHocPhi = new System.Windows.Forms.DataGridView();
            this.colNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienDaDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlPrepareNhapDiem.SuspendLayout();
            this.gbxNhapDiemCho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Controls.Add(this.btnPhucHoi);
            this.panel1.Controls.Add(this.btnGhi);
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
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
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
            // btnGhi
            // 
            this.btnGhi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Appearance.Options.UseFont = true;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Location = new System.Drawing.Point(12, 12);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(188, 61);
            this.btnGhi.TabIndex = 0;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
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
            this.gbxNhapDiemCho.Controls.Add(this.btnBatDau);
            this.gbxNhapDiemCho.Controls.Add(this.txtMaLop);
            this.gbxNhapDiemCho.Controls.Add(this.txtHoTen);
            this.gbxNhapDiemCho.Controls.Add(this.cbxMaSinhVien);
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
            // btnBatDau
            // 
            this.btnBatDau.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Appearance.Options.UseFont = true;
            this.btnBatDau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBatDau.ImageOptions.SvgImage")));
            this.btnBatDau.Location = new System.Drawing.Point(346, 314);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(142, 47);
            this.btnBatDau.TabIndex = 6;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMaLop.Location = new System.Drawing.Point(168, 234);
            this.txtMaLop.Multiline = true;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(320, 36);
            this.txtMaLop.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(168, 168);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(320, 36);
            this.txtHoTen.TabIndex = 5;
            // 
            // cbxMaSinhVien
            // 
            this.cbxMaSinhVien.BackColor = System.Drawing.Color.White;
            this.cbxMaSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxMaSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaSinhVien.FormattingEnabled = true;
            this.cbxMaSinhVien.IntegralHeight = false;
            this.cbxMaSinhVien.Location = new System.Drawing.Point(168, 95);
            this.cbxMaSinhVien.Name = "cbxMaSinhVien";
            this.cbxMaSinhVien.Size = new System.Drawing.Size(320, 36);
            this.cbxMaSinhVien.TabIndex = 4;
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
            // dgvHocPhi
            // 
            this.dgvHocPhi.AllowUserToDeleteRows = false;
            this.dgvHocPhi.AllowUserToResizeRows = false;
            this.dgvHocPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvHocPhi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocPhi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNienKhoa,
            this.colHocKy,
            this.colHocPhi,
            this.colSoTienDaDong});
            this.dgvHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocPhi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvHocPhi.Location = new System.Drawing.Point(549, 86);
            this.dgvHocPhi.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dgvHocPhi.MultiSelect = false;
            this.dgvHocPhi.Name = "dgvHocPhi";
            this.dgvHocPhi.RowHeadersVisible = false;
            this.dgvHocPhi.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvHocPhi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHocPhi.RowTemplate.Height = 28;
            this.dgvHocPhi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocPhi.Size = new System.Drawing.Size(827, 662);
            this.dgvHocPhi.TabIndex = 8;
            this.dgvHocPhi.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvHocPhi_CellValidating);
            // 
            // colNienKhoa
            // 
            this.colNienKhoa.DataPropertyName = "NienKhoa";
            this.colNienKhoa.HeaderText = "Niên khóa";
            this.colNienKhoa.MaxInputLength = 9;
            this.colNienKhoa.MinimumWidth = 8;
            this.colNienKhoa.Name = "colNienKhoa";
            // 
            // colHocKy
            // 
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.MaxInputLength = 1;
            this.colHocKy.MinimumWidth = 8;
            this.colHocKy.Name = "colHocKy";
            // 
            // colHocPhi
            // 
            this.colHocPhi.DataPropertyName = "HocPhi";
            dataGridViewCellStyle2.NullValue = null;
            this.colHocPhi.DefaultCellStyle = dataGridViewCellStyle2;
            this.colHocPhi.HeaderText = "Học phí (VND)";
            this.colHocPhi.MinimumWidth = 8;
            this.colHocPhi.Name = "colHocPhi";
            // 
            // colSoTienDaDong
            // 
            this.colSoTienDaDong.DataPropertyName = "SoTienDaDong";
            dataGridViewCellStyle3.NullValue = null;
            this.colSoTienDaDong.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSoTienDaDong.HeaderText = "Số tiền đã đóng (VND)";
            this.colSoTienDaDong.MinimumWidth = 8;
            this.colSoTienDaDong.Name = "colSoTienDaDong";
            // 
            // frmHocPhi
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 748);
            this.Controls.Add(this.dgvHocPhi);
            this.Controls.Add(this.pnlPrepareNhapDiem);
            this.Controls.Add(this.panel1);
            this.Name = "frmHocPhi";
            this.Text = "Học phí";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            this.panel1.ResumeLayout(false);
            this.pnlPrepareNhapDiem.ResumeLayout(false);
            this.gbxNhapDiemCho.ResumeLayout(false);
            this.gbxNhapDiemCho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
        private DevExpress.XtraEditors.SimpleButton btnPhucHoi;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private System.Windows.Forms.Panel pnlPrepareNhapDiem;
        private System.Windows.Forms.GroupBox gbxNhapDiemCho;
        private System.Windows.Forms.ComboBox cbxMaSinhVien;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.DataGridView dgvHocPhi;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienDaDong;
    }
}