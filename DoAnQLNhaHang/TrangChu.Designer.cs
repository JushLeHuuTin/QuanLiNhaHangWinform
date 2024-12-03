namespace DoAnQLNhaHang
{
    partial class frmTrangChu
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
            this.label1 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbSoBan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSMonAn = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBotMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sơ đồ bàn ăn";
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(8, 109);
            this.flpTable.Margin = new System.Windows.Forms.Padding(2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(356, 514);
            this.flpTable.TabIndex = 1;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbTrangThai);
            this.panel1.Controls.Add(this.lbSoBan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(364, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 65);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mở Bàn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lbTrangThai.Location = new System.Drawing.Point(224, 37);
            this.lbTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(61, 13);
            this.lbTrangThai.TabIndex = 3;
            this.lbTrangThai.Text = "Không có";
            // 
            // lbSoBan
            // 
            this.lbSoBan.AutoSize = true;
            this.lbSoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoBan.ForeColor = System.Drawing.Color.Red;
            this.lbSoBan.Location = new System.Drawing.Point(224, 8);
            this.lbSoBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoBan.Name = "lbSoBan";
            this.lbSoBan.Size = new System.Drawing.Size(68, 13);
            this.lbSoBan.TabIndex = 2;
            this.lbSoBan.Text = "Chưa chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bàn:";
            // 
            // dgvDSMonAn
            // 
            this.dgvDSMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonAn.Location = new System.Drawing.Point(39, 20);
            this.dgvDSMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSMonAn.Name = "dgvDSMonAn";
            this.dgvDSMonAn.RowHeadersWidth = 51;
            this.dgvDSMonAn.RowTemplate.Height = 24;
            this.dgvDSMonAn.Size = new System.Drawing.Size(392, 511);
            this.dgvDSMonAn.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(873, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 64);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(126, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh sách món ăn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btnBotMon);
            this.panel3.Controls.Add(this.btnThemMon);
            this.panel3.Location = new System.Drawing.Point(339, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 341);
            this.panel3.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 157);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "Chuyển Bàn";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBotMon
            // 
            this.btnBotMon.Location = new System.Drawing.Point(4, 90);
            this.btnBotMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnBotMon.Name = "btnBotMon";
            this.btnBotMon.Size = new System.Drawing.Size(112, 41);
            this.btnBotMon.TabIndex = 6;
            this.btnBotMon.Text = "Bớt Món >>";
            this.btnBotMon.UseVisualStyleBackColor = true;
            this.btnBotMon.Click += new System.EventHandler(this.btnBotMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(2, 29);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(112, 41);
            this.btnThemMon.TabIndex = 5;
            this.btnThemMon.Text = "<< Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.txtThanhTien);
            this.panel4.Controls.Add(this.txtGiamGia);
            this.panel4.Controls.Add(this.txtVoucher);
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(16, 363);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 205);
            this.panel4.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(336, 113);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 41);
            this.button7.TabIndex = 11;
            this.button7.Text = "Thanh Toán";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(336, 10);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "In Hóa Đơn";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(117, 125);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(184, 23);
            this.txtThanhTien.TabIndex = 10;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Location = new System.Drawing.Point(117, 86);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.ReadOnly = true;
            this.txtGiamGia.Size = new System.Drawing.Size(184, 23);
            this.txtGiamGia.TabIndex = 9;
            this.txtGiamGia.Leave += new System.EventHandler(this.txtGiamGia_Leave);
            // 
            // txtVoucher
            // 
            this.txtVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoucher.Location = new System.Drawing.Point(117, 45);
            this.txtVoucher.Margin = new System.Windows.Forms.Padding(2);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(184, 23);
            this.txtVoucher.TabIndex = 9;
            this.txtVoucher.Leave += new System.EventHandler(this.txtVoucher_Leave);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Location = new System.Drawing.Point(117, 10);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(184, 23);
            this.txtTongTien.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Được giảm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thành Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nhập Voucher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng Cộng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1378, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLMónToolStripMenuItem,
            this.qLBànToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // qLMónToolStripMenuItem
            // 
            this.qLMónToolStripMenuItem.Name = "qLMónToolStripMenuItem";
            this.qLMónToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.qLMónToolStripMenuItem.Text = "QL Món";
            this.qLMónToolStripMenuItem.Click += new System.EventHandler(this.qLMónToolStripMenuItem_Click);
            // 
            // qLBànToolStripMenuItem
            // 
            this.qLBànToolStripMenuItem.Name = "qLBànToolStripMenuItem";
            this.qLBànToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.qLBànToolStripMenuItem.Text = "QL Bàn";
            this.qLBànToolStripMenuItem.Click += new System.EventHandler(this.qLBànToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(17, 17);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(318, 341);
            this.dgvCTHD.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvCTHD);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(369, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 591);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvDSMonAn);
            this.panel6.Location = new System.Drawing.Point(873, 109);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(466, 561);
            this.panel6.TabIndex = 10;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 758);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn ăn";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDSMonAn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbSoBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBotMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label8;
    }
}

