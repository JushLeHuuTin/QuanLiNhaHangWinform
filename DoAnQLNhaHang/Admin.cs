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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ShowForm(new frmQLThucDon());
        }
        private void ShowForm(Form from)
        {
            pnAdmin.Controls.Clear();
            from.TopLevel = false;
            from.FormBorderStyle = FormBorderStyle.None;
            from.Dock = DockStyle.Fill;

            pnAdmin.Controls.Add(from);
            from.Show();
        }

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            ShowForm(new frmQLBan());
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            ShowForm(new frmQLTaiKhoan());
        }

        private void btnBep_Click(object sender, EventArgs e)
        {
            ShowForm(new frmQLThucDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ShowForm(new ThongKeHoaDon());
        }
    }
}
