namespace DoAnQLNhaHang
{
    partial class ThongKeHoaDon
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
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.tmpCheckout = new System.Windows.Forms.DateTimePicker();
            this.dgvThongKeHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bếpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeHoaDon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Location = new System.Drawing.Point(12, 37);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckin.TabIndex = 0;
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);
            // 
            // tmpCheckout
            // 
            this.tmpCheckout.Location = new System.Drawing.Point(896, 37);
            this.tmpCheckout.Name = "tmpCheckout";
            this.tmpCheckout.Size = new System.Drawing.Size(235, 20);
            this.tmpCheckout.TabIndex = 0;
            this.tmpCheckout.ValueChanged += new System.EventHandler(this.tmpCheckout_ValueChanged);
            // 
            // dgvThongKeHoaDon
            // 
            this.dgvThongKeHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeHoaDon.Location = new System.Drawing.Point(12, 78);
            this.dgvThongKeHoaDon.Name = "dgvThongKeHoaDon";
            this.dgvThongKeHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeHoaDon.Size = new System.Drawing.Size(1119, 685);
            this.dgvThongKeHoaDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.bếpToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // bếpToolStripMenuItem
            // 
            this.bếpToolStripMenuItem.Name = "bếpToolStripMenuItem";
            this.bếpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bếpToolStripMenuItem.Text = "Bếp";
            this.bếpToolStripMenuItem.Click += new System.EventHandler(this.bếpToolStripMenuItem_Click);
            // 
            // ThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongKeHoaDon);
            this.Controls.Add(this.tmpCheckout);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThongKeHoaDon";
            this.Text = "ThongKeHoaDon";
            this.Load += new System.EventHandler(this.ThongKeHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeHoaDon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.DateTimePicker tmpCheckout;
        private System.Windows.Forms.DataGridView dgvThongKeHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bếpToolStripMenuItem;
    }
}