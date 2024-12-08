using BUS;
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
    public partial class ThongKeHoaDon : Form
    {
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        public ThongKeHoaDon()
        {
            InitializeComponent();
            LoadDateTimePicker();
            LoadHoaDon(dtpCheckin.Value,tmpCheckout.Value);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
        }
        public void LoadDateTimePicker()
        {
            
            DateTime today = DateTime.Now;
            dtpCheckin.Value = new DateTime(today.Year, today.Month,1);
            tmpCheckout.Value = dtpCheckin.Value.AddMonths(1).AddDays(-1);
        }
        private void LoadHoaDon(DateTime s, DateTime e)
        {
            dgvThongKeHoaDon.DataSource = HoaDonBUS.ThongkeHoaDon(s, e);
        }

        private void ThongKeHoaDon_Load(object sender, EventArgs e)
        {
          
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            LoadHoaDon(dtpCheckin.Value, tmpCheckout.Value);
        }

        private void tmpCheckout_ValueChanged(object sender, EventArgs e)
        {
            LoadHoaDon(dtpCheckin.Value, tmpCheckout.Value);

        }
    }
}
