namespace QuanLyDiemSinhVien.InputGUI
{
    partial class frmInputBangDiemMonHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxLanThi = new System.Windows.Forms.ComboBox();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaMonHoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 565);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cbxLanThi);
            this.panel2.Controls.Add(this.cbxMonHoc);
            this.panel2.Controls.Add(this.cbxLop);
            this.panel2.Controls.Add(this.cbxKhoa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMaMonHoc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblMaLop);
            this.panel2.Controls.Add(this.btnXacNhan);
            this.panel2.Location = new System.Drawing.Point(540, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 409);
            this.panel2.TabIndex = 34;
            // 
            // cbxLanThi
            // 
            this.cbxLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanThi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLanThi.FormattingEnabled = true;
            this.cbxLanThi.Location = new System.Drawing.Point(363, 214);
            this.cbxLanThi.Name = "cbxLanThi";
            this.cbxLanThi.Size = new System.Drawing.Size(289, 36);
            this.cbxLanThi.TabIndex = 38;
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(363, 158);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(289, 36);
            this.cbxMonHoc.TabIndex = 39;
            this.cbxMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbxMonHoc_SelectedIndexChanged);
            // 
            // cbxLop
            // 
            this.cbxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(363, 104);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(289, 36);
            this.cbxLop.TabIndex = 40;
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLop_SelectedIndexChanged);
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(363, 47);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(289, 36);
            this.cbxKhoa.TabIndex = 41;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Lần thi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaMonHoc
            // 
            this.lblMaMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMonHoc.ForeColor = System.Drawing.Color.White;
            this.lblMaMonHoc.Location = new System.Drawing.Point(216, 158);
            this.lblMaMonHoc.Name = "lblMaMonHoc";
            this.lblMaMonHoc.Size = new System.Drawing.Size(135, 28);
            this.lblMaMonHoc.TabIndex = 35;
            this.lblMaMonHoc.Text = "Môn học:";
            this.lblMaMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Khoa:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaLop
            // 
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.ForeColor = System.Drawing.Color.White;
            this.lblMaLop.Location = new System.Drawing.Point(216, 107);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(135, 28);
            this.lblMaLop.TabIndex = 37;
            this.lblMaLop.Text = "Lớp:";
            this.lblMaLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(501, 286);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(151, 62);
            this.btnXacNhan.TabIndex = 33;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmInputBangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 565);
            this.Controls.Add(this.panel1);
            this.Name = "frmInputBangDiemMonHoc";
            this.Text = "In Bảng Điểm Môn Học";
            this.Load += new System.EventHandler(this.frmInputBangDiemMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cbxLanThi;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaLop;
    }
}