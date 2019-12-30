namespace QuanLyDiemSinhVien.NhapDiemGUI
{
    partial class frmNhapDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhapDiem = new DevExpress.XtraEditors.SimpleButton();
            this.gbxNhapDiemCho = new System.Windows.Forms.GroupBox();
            this.btnChonLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.cbxLanThu = new System.Windows.Forms.ComboBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblLanThi = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.pnlPrepareNhapDiem = new System.Windows.Forms.Panel();
            this.dgvNhapDiem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbxNhapDiemCho.SuspendLayout();
            this.pnlPrepareNhapDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Controls.Add(this.btnPhucHoi);
            this.panel1.Controls.Add(this.btnSuaDiem);
            this.panel1.Controls.Add(this.btnNhapDiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 86);
            this.panel1.TabIndex = 3;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Appearance.Options.UseFont = true;
            this.btnTaiLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiLai.ImageOptions.SvgImage")));
            this.btnTaiLai.Location = new System.Drawing.Point(400, 12);
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
            this.btnPhucHoi.Location = new System.Drawing.Point(594, 12);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(188, 61);
            this.btnPhucHoi.TabIndex = 0;
            this.btnPhucHoi.Text = "Phục hồi";
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDiem.Appearance.Options.UseFont = true;
            this.btnSuaDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaDiem.ImageOptions.SvgImage")));
            this.btnSuaDiem.Location = new System.Drawing.Point(206, 12);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.Size = new System.Drawing.Size(188, 61);
            this.btnSuaDiem.TabIndex = 0;
            this.btnSuaDiem.Text = "Sửa điểm";
            this.btnSuaDiem.Click += new System.EventHandler(this.btnSuaDiem_Click);
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
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // gbxNhapDiemCho
            // 
            this.gbxNhapDiemCho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbxNhapDiemCho.Controls.Add(this.btnChonLai);
            this.gbxNhapDiemCho.Controls.Add(this.btnBatDau);
            this.gbxNhapDiemCho.Controls.Add(this.cbxMonHoc);
            this.gbxNhapDiemCho.Controls.Add(this.cbxLanThu);
            this.gbxNhapDiemCho.Controls.Add(this.cbxKhoa);
            this.gbxNhapDiemCho.Controls.Add(this.cbxLop);
            this.gbxNhapDiemCho.Controls.Add(this.lblMonHoc);
            this.gbxNhapDiemCho.Controls.Add(this.lblLanThi);
            this.gbxNhapDiemCho.Controls.Add(this.lblKhoa);
            this.gbxNhapDiemCho.Controls.Add(this.lblLop);
            this.gbxNhapDiemCho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxNhapDiemCho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNhapDiemCho.ForeColor = System.Drawing.Color.White;
            this.gbxNhapDiemCho.Location = new System.Drawing.Point(20, 20);
            this.gbxNhapDiemCho.Name = "gbxNhapDiemCho";
            this.gbxNhapDiemCho.Size = new System.Drawing.Size(509, 622);
            this.gbxNhapDiemCho.TabIndex = 5;
            this.gbxNhapDiemCho.TabStop = false;
            this.gbxNhapDiemCho.Text = "Nhập điểm cho: ";
            // 
            // btnChonLai
            // 
            this.btnChonLai.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonLai.Appearance.Options.UseFont = true;
            this.btnChonLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChonLai.ImageOptions.SvgImage")));
            this.btnChonLai.Location = new System.Drawing.Point(162, 343);
            this.btnChonLai.Name = "btnChonLai";
            this.btnChonLai.Size = new System.Drawing.Size(142, 47);
            this.btnChonLai.TabIndex = 5;
            this.btnChonLai.Text = "Chọn lại";
            this.btnChonLai.Click += new System.EventHandler(this.btnChonLai_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Appearance.Options.UseFont = true;
            this.btnBatDau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBatDau.ImageOptions.SvgImage")));
            this.btnBatDau.Location = new System.Drawing.Point(326, 343);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(142, 47);
            this.btnBatDau.TabIndex = 5;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxMonHoc.DropDownHeight = 150;
            this.cbxMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.IntegralHeight = false;
            this.cbxMonHoc.Location = new System.Drawing.Point(148, 202);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(320, 36);
            this.cbxMonHoc.TabIndex = 4;
            this.cbxMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbxLopAndcbxMonHoc_SelectedIndexChanged);
            // 
            // cbxLanThu
            // 
            this.cbxLanThu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxLanThu.DropDownHeight = 100;
            this.cbxLanThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanThu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLanThu.ForeColor = System.Drawing.Color.White;
            this.cbxLanThu.FormattingEnabled = true;
            this.cbxLanThu.IntegralHeight = false;
            this.cbxLanThu.Location = new System.Drawing.Point(148, 256);
            this.cbxLanThu.Name = "cbxLanThu";
            this.cbxLanThu.Size = new System.Drawing.Size(320, 36);
            this.cbxLanThu.TabIndex = 4;
            this.cbxLanThu.SelectedIndexChanged += new System.EventHandler(this.cbxLanThu_SelectedIndexChanged);
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoa.Location = new System.Drawing.Point(148, 94);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(320, 36);
            this.cbxKhoa.TabIndex = 4;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // cbxLop
            // 
            this.cbxLop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxLop.DropDownHeight = 150;
            this.cbxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.IntegralHeight = false;
            this.cbxLop.Location = new System.Drawing.Point(148, 148);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(320, 36);
            this.cbxLop.TabIndex = 4;
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLopAndcbxMonHoc_SelectedIndexChanged);
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.ForeColor = System.Drawing.Color.White;
            this.lblMonHoc.Location = new System.Drawing.Point(16, 201);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(126, 36);
            this.lblMonHoc.TabIndex = 3;
            this.lblMonHoc.Text = "Môn học:";
            this.lblMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLanThi
            // 
            this.lblLanThi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanThi.ForeColor = System.Drawing.Color.White;
            this.lblLanThi.Location = new System.Drawing.Point(16, 256);
            this.lblLanThi.Name = "lblLanThi";
            this.lblLanThi.Size = new System.Drawing.Size(126, 36);
            this.lblLanThi.TabIndex = 3;
            this.lblLanThi.Text = "Lần thứ:";
            this.lblLanThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKhoa
            // 
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.ForeColor = System.Drawing.Color.White;
            this.lblKhoa.Location = new System.Drawing.Point(16, 93);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(126, 36);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa:";
            this.lblKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLop
            // 
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.ForeColor = System.Drawing.Color.White;
            this.lblLop.Location = new System.Drawing.Point(16, 147);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(126, 36);
            this.lblLop.TabIndex = 3;
            this.lblLop.Text = "Lớp:";
            this.lblLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.pnlPrepareNhapDiem.TabIndex = 6;
            // 
            // dgvNhapDiem
            // 
            this.dgvNhapDiem.AllowUserToAddRows = false;
            this.dgvNhapDiem.AllowUserToDeleteRows = false;
            this.dgvNhapDiem.AllowUserToResizeRows = false;
            this.dgvNhapDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvNhapDiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhapDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapDiem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNhapDiem.Location = new System.Drawing.Point(549, 86);
            this.dgvNhapDiem.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dgvNhapDiem.MultiSelect = false;
            this.dgvNhapDiem.Name = "dgvNhapDiem";
            this.dgvNhapDiem.RowHeadersVisible = false;
            this.dgvNhapDiem.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvNhapDiem.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhapDiem.RowTemplate.Height = 28;
            this.dgvNhapDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapDiem.Size = new System.Drawing.Size(827, 662);
            this.dgvNhapDiem.TabIndex = 7;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 748);
            this.Controls.Add(this.dgvNhapDiem);
            this.Controls.Add(this.pnlPrepareNhapDiem);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            this.panel1.ResumeLayout(false);
            this.gbxNhapDiemCho.ResumeLayout(false);
            this.pnlPrepareNhapDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnPhucHoi;
        private DevExpress.XtraEditors.SimpleButton btnSuaDiem;
        private DevExpress.XtraEditors.SimpleButton btnNhapDiem;
        private System.Windows.Forms.GroupBox gbxNhapDiemCho;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Panel pnlPrepareNhapDiem;
        private System.Windows.Forms.DataGridView dgvNhapDiem;
        private System.Windows.Forms.ComboBox cbxLop;
        private DevExpress.XtraEditors.SimpleButton btnBatDau;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblLanThi;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbxLanThu;
        private DevExpress.XtraEditors.SimpleButton btnChonLai;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
    }
}