﻿namespace QuanLyDiemSinhVien.InputGUI
{
    partial class frmInputPhieuDiem
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.lblMaLop);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Location = new System.Drawing.Point(381, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 224);
            this.panel1.TabIndex = 0;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnXacNhan.Location = new System.Drawing.Point(360, 120);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(112, 49);
            this.btnXacNhan.TabIndex = 26;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // lblMaLop
            // 
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.ForeColor = System.Drawing.Color.White;
            this.lblMaLop.Location = new System.Drawing.Point(10, 59);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(166, 28);
            this.lblMaLop.TabIndex = 25;
            this.lblMaLop.Text = "Mã sinh viên:";
            this.lblMaLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(183, 56);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(289, 34);
            this.txtMaSV.TabIndex = 24;
            // 
            // frmInputPhieuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 553);
            this.Controls.Add(this.panel1);
            this.Name = "frmInputPhieuDiem";
            this.Text = "In Phiếu Điểm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaSV;
    }
}