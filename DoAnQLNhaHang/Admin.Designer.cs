﻿namespace DoAnQLNhaHang
{
    partial class Admin
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
            this.btnBep = new System.Windows.Forms.Button();
            this.btnQLBan = new System.Windows.Forms.Button();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnQLTaiKhoan);
            this.panel1.Controls.Add(this.btnQLBan);
            this.panel1.Controls.Add(this.btnBep);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnBep
            // 
            this.btnBep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBep.Location = new System.Drawing.Point(288, 19);
            this.btnBep.Name = "btnBep";
            this.btnBep.Size = new System.Drawing.Size(126, 23);
            this.btnBep.TabIndex = 0;
            this.btnBep.Text = "Bếp";
            this.btnBep.UseVisualStyleBackColor = false;
            this.btnBep.Click += new System.EventHandler(this.btnBep_Click);
            // 
            // btnQLBan
            // 
            this.btnQLBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnQLBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLBan.Location = new System.Drawing.Point(455, 19);
            this.btnQLBan.Name = "btnQLBan";
            this.btnQLBan.Size = new System.Drawing.Size(134, 23);
            this.btnQLBan.TabIndex = 0;
            this.btnQLBan.Text = "Sửa Chữa Bàn";
            this.btnQLBan.UseVisualStyleBackColor = false;
            this.btnQLBan.Click += new System.EventHandler(this.btnQLBan_Click);
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(634, 19);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(123, 23);
            this.btnQLTaiKhoan.TabIndex = 0;
            this.btnQLTaiKhoan.Text = "Quản lí tài khoản";
            this.btnQLTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // pnAdmin
            // 
            this.pnAdmin.Location = new System.Drawing.Point(5, 70);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(1215, 724);
            this.pnAdmin.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Location = new System.Drawing.Point(796, 19);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(123, 23);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 796);
            this.Controls.Add(this.pnAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBep;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnQLBan;
        private System.Windows.Forms.Panel pnAdmin;
        private System.Windows.Forms.Button btnThongKe;
    }
}