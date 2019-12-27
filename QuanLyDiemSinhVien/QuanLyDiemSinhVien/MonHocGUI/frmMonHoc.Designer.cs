namespace QuanLyDiemSinhVien.MonHocGUI
{
    partial class frmMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThemMonHoc = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhucHoiMonHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaBoMonHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatMonHoc = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMaMonHoc = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.lblTenMonHoc = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReLoad = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMonHoc.Appearance.Options.UseFont = true;
            this.btnThemMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemMonHoc.ImageOptions.SvgImage")));
            this.btnThemMonHoc.Location = new System.Drawing.Point(12, 12);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(188, 61);
            this.btnThemMonHoc.TabIndex = 0;
            this.btnThemMonHoc.Text = "Thêm vào";
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.btnReLoad);
            this.panel1.Controls.Add(this.btnPhucHoiMonHoc);
            this.panel1.Controls.Add(this.btnXoaBoMonHoc);
            this.panel1.Controls.Add(this.btnCapNhatMonHoc);
            this.panel1.Controls.Add(this.btnThemMonHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 86);
            this.panel1.TabIndex = 2;
            // 
            // btnPhucHoiMonHoc
            // 
            this.btnPhucHoiMonHoc.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoiMonHoc.Appearance.Options.UseFont = true;
            this.btnPhucHoiMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiMonHoc.ImageOptions.SvgImage")));
            this.btnPhucHoiMonHoc.Location = new System.Drawing.Point(788, 12);
            this.btnPhucHoiMonHoc.Name = "btnPhucHoiMonHoc";
            this.btnPhucHoiMonHoc.Size = new System.Drawing.Size(188, 61);
            this.btnPhucHoiMonHoc.TabIndex = 0;
            this.btnPhucHoiMonHoc.Text = "Phục hồi";
            this.btnPhucHoiMonHoc.Click += new System.EventHandler(this.btnPhucHoiMonHoc_Click);
            // 
            // btnXoaBoMonHoc
            // 
            this.btnXoaBoMonHoc.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBoMonHoc.Appearance.Options.UseFont = true;
            this.btnXoaBoMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaBoMonHoc.ImageOptions.SvgImage")));
            this.btnXoaBoMonHoc.Location = new System.Drawing.Point(400, 12);
            this.btnXoaBoMonHoc.Name = "btnXoaBoMonHoc";
            this.btnXoaBoMonHoc.Size = new System.Drawing.Size(188, 61);
            this.btnXoaBoMonHoc.TabIndex = 0;
            this.btnXoaBoMonHoc.Text = "Xóa bỏ";
            this.btnXoaBoMonHoc.Click += new System.EventHandler(this.btnXoaBoMonHoc_Click);
            // 
            // btnCapNhatMonHoc
            // 
            this.btnCapNhatMonHoc.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatMonHoc.Appearance.Options.UseFont = true;
            this.btnCapNhatMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatMonHoc.ImageOptions.SvgImage")));
            this.btnCapNhatMonHoc.Location = new System.Drawing.Point(206, 12);
            this.btnCapNhatMonHoc.Name = "btnCapNhatMonHoc";
            this.btnCapNhatMonHoc.Size = new System.Drawing.Size(188, 61);
            this.btnCapNhatMonHoc.TabIndex = 0;
            this.btnCapNhatMonHoc.Text = "Cập nhật";
            this.btnCapNhatMonHoc.Click += new System.EventHandler(this.btnCapNhatMonHoc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblMaMonHoc);
            this.panel2.Controls.Add(this.txtMaMonHoc);
            this.panel2.Controls.Add(this.lblTenMonHoc);
            this.panel2.Controls.Add(this.txtTenMonHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(825, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 662);
            this.panel2.TabIndex = 3;
            // 
            // lblMaMonHoc
            // 
            this.lblMaMonHoc.AutoSize = true;
            this.lblMaMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMonHoc.ForeColor = System.Drawing.Color.White;
            this.lblMaMonHoc.Location = new System.Drawing.Point(24, 132);
            this.lblMaMonHoc.Name = "lblMaMonHoc";
            this.lblMaMonHoc.Size = new System.Drawing.Size(135, 28);
            this.lblMaMonHoc.TabIndex = 1;
            this.lblMaMonHoc.Text = "Mã môn học:";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(171, 129);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(351, 34);
            this.txtMaMonHoc.TabIndex = 0;
            // 
            // lblTenMonHoc
            // 
            this.lblTenMonHoc.AutoSize = true;
            this.lblTenMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonHoc.ForeColor = System.Drawing.Color.White;
            this.lblTenMonHoc.Location = new System.Drawing.Point(24, 186);
            this.lblTenMonHoc.Name = "lblTenMonHoc";
            this.lblTenMonHoc.Size = new System.Drawing.Size(138, 28);
            this.lblTenMonHoc.TabIndex = 1;
            this.lblTenMonHoc.Text = "Tên môn học:";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.Location = new System.Drawing.Point(171, 183);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(351, 34);
            this.txtTenMonHoc.TabIndex = 0;
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AllowUserToResizeRows = false;
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 0);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvMonHoc.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMonHoc.RowTemplate.Height = 28;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(820, 662);
            this.dgvMonHoc.TabIndex = 4;
            this.dgvMonHoc.Click += new System.EventHandler(this.dgvMonHoc_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMonHoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel3.Size = new System.Drawing.Size(825, 662);
            this.panel3.TabIndex = 5;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Appearance.Options.UseFont = true;
            this.btnReLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnReLoad.Location = new System.Drawing.Point(594, 12);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(188, 61);
            this.btnReLoad.TabIndex = 0;
            this.btnReLoad.Text = "Tải lại";
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 748);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMonHoc";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThemMonHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMaMonHoc;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label lblTenMonHoc;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private DevExpress.XtraEditors.SimpleButton btnPhucHoiMonHoc;
        private DevExpress.XtraEditors.SimpleButton btnXoaBoMonHoc;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatMonHoc;
        private DevExpress.XtraEditors.SimpleButton btnReLoad;
    }
}