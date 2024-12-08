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
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        private int maBan = -1;
        private string type;
        public frmReport(int maBan)
        {
            this.maBan = maBan;
            InitializeComponent();
        }
        public frmReport(string type)
        {
            this.type = type;
            InitializeComponent();
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            MenuBUS menuBUS = new MenuBUS();

            // Tạo một DataTable hoặc danh sách dữ liệu
            TableET table = new TableET();
            table.MaBan = maBan;
            DataTable dataTable = new DataTable();
            reportViewer1.Reset(); // Xóa cấu hình trước (nếu có)
            if (type == "Menu")
            {
                QLMonAnBUS qLMonAnBUS = new QLMonAnBUS();
                 dataTable = qLMonAnBUS.DSMonAnchoBaoCao();
               reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnQLNhaHang.rptMonAn.rdlc"; // Đường dẫn RDLC
            }
            else if(type == "HoaDon")
            {
                DateTimePicker s = new DateTimePicker();
                s.Value = new DateTime (s.Value.Year,s.Value.Month,1);
                DateTimePicker d  = new DateTimePicker();
                d.Value = s.Value.AddMonths (1).AddDays(-1);
                 dataTable = HoaDonBUS.ThongkeHoaDon(s.Value, d.Value);
                reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnQLNhaHang.rptThongKeHoaDon.rdlc"; // Đường dẫn RDLC
            }
            else
            {
                dataTable = menuBUS.InHoaDon(table);
                reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnQLNhaHang.RPTHoaDon.rdlc"; // Đường dẫn RDLC

            }
            reportViewer1.LocalReport.DataSources.Clear();

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
