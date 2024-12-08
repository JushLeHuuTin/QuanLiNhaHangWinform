using BUS;
using ET;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLNhaHang
{
    public partial class frmReport : Form
    {
        private int maBan;
        public frmReport(int maBan)
        {
            this.maBan = maBan;
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            MenuBUS menuBUS = new MenuBUS();

            // Tạo một DataTable hoặc danh sách dữ liệu
            TableET table = new TableET();
            table.MaBan = maBan;
            DataTable dataTable = menuBUS.InHoaDon(table); 

            // Gán dữ liệu vào DataSet
            ReportDataSource rds = new ReportDataSource("DataSet1", dataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Refresh để hiển thị dữ liệu
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Refresh();
        }
    }
}
