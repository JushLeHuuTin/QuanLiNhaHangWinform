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
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Location = new System.Drawing.Point(12, 12);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckin.TabIndex = 0;
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);
            // 
            // tmpCheckout
            // 
            this.tmpCheckout.Location = new System.Drawing.Point(588, 12);
            this.tmpCheckout.Name = "tmpCheckout";
            this.tmpCheckout.Size = new System.Drawing.Size(200, 20);
            this.tmpCheckout.TabIndex = 0;
            this.tmpCheckout.ValueChanged += new System.EventHandler(this.tmpCheckout_ValueChanged);
            // 
            // dgvThongKeHoaDon
            // 
            this.dgvThongKeHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeHoaDon.Location = new System.Drawing.Point(12, 53);
            this.dgvThongKeHoaDon.Name = "dgvThongKeHoaDon";
            this.dgvThongKeHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeHoaDon.Size = new System.Drawing.Size(776, 385);
            this.dgvThongKeHoaDon.TabIndex = 1;
            // 
            // ThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvThongKeHoaDon);
            this.Controls.Add(this.tmpCheckout);
            this.Controls.Add(this.dtpCheckin);
            this.Name = "ThongKeHoaDon";
            this.Text = "ThongKeHoaDon";
            this.Load += new System.EventHandler(this.ThongKeHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.DateTimePicker tmpCheckout;
        private System.Windows.Forms.DataGridView dgvThongKeHoaDon;
    }
}