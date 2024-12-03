namespace DoAnQLNhaHang
{
    partial class frmQLBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTrangThaiBan = new System.Windows.Forms.ComboBox();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBanAn = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTrangThaiBan);
            this.groupBox1.Controls.Add(this.cbTang);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvBanAn);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenBan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(585, 632);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bàn Ăn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tầng";
            // 
            // cbTrangThaiBan
            // 
            this.cbTrangThaiBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThaiBan.FormattingEnabled = true;
            this.cbTrangThaiBan.Items.AddRange(new object[] {
            "Trống",
            "Đặt trước",
            "Có người"});
            this.cbTrangThaiBan.Location = new System.Drawing.Point(265, 128);
            this.cbTrangThaiBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbTrangThaiBan.Name = "cbTrangThaiBan";
            this.cbTrangThaiBan.Size = new System.Drawing.Size(102, 28);
            this.cbTrangThaiBan.TabIndex = 11;
            this.cbTrangThaiBan.SelectedIndexChanged += new System.EventHandler(this.cbTang_SelectedIndexChanged);
            // 
            // cbTang
            // 
            this.cbTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2"});
            this.cbTang.Location = new System.Drawing.Point(265, 83);
            this.cbTang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(102, 28);
            this.cbTang.TabIndex = 11;
            this.cbTang.SelectedIndexChanged += new System.EventHandler(this.cbTang_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(377, 268);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 31);
            this.button4.TabIndex = 10;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(111, 271);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 23);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tìm Kiếm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvBanAn
            // 
            this.dgvBanAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBanAn.Location = new System.Drawing.Point(3, 309);
            this.dgvBanAn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvBanAn.Name = "dgvBanAn";
            this.dgvBanAn.RowHeadersWidth = 51;
            this.dgvBanAn.RowTemplate.Height = 24;
            this.dgvBanAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanAn.Size = new System.Drawing.Size(579, 318);
            this.dgvBanAn.TabIndex = 7;
            this.dgvBanAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanAn_CellContentClick);
            this.dgvBanAn.Click += new System.EventHandler(this.dgvBanAn_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(238, 181);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 56);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(138, 181);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 56);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(42, 181);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 56);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenBan
            // 
            this.txtTenBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenBan.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.Location = new System.Drawing.Point(265, 50);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(249, 23);
            this.txtTenBan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng Thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Bàn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            // 
            // qLBànToolStripMenuItem
            // 
            this.qLBànToolStripMenuItem.Name = "qLBànToolStripMenuItem";
            this.qLBànToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.qLBànToolStripMenuItem.Text = "QL Bàn";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // frmQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmQLBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLBan";
            this.Load += new System.EventHandler(this.frmQLBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvBanAn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.ComboBox cbTrangThaiBan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}