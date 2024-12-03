using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET;

namespace DoAnQLNhaHang
{
    public partial class frmQLBan : Form
    {
        QLBanBUS banBus = new QLBanBUS();
        public frmQLBan()
        {
            InitializeComponent();
        }

        private void frmQLBan_Load(object sender, EventArgs e)
        {
            dgvBanAn.DataSource = banBus.DanhSachBan();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvBanAn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvBanAn.CurrentRow;
            txtMaBan.Text = row.Cells[0].Value.ToString().Trim();
            txtTenBan.Text = row.Cells[1].Value.ToString().Trim();
            cbTrangThaiBan.Text = row.Cells[3].Value.ToString().Trim();
            cbTang.Text = row.Cells[2].Value.ToString().Trim();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TableET tableET = new TableET(txtMaBan.Text.Trim(),txtTenBan.Text.Trim(),cbTang.Text.Trim(),cbTrangThaiBan.Text.Trim());

            if (banBus.ThemBan(tableET) != 0)
            {
                dgvBanAn.DataSource = banBus.DanhSachBan();
                MessageBox.Show("Thêm bàn thành công !");
            }
            else{
                MessageBox.Show("Thêm thất bại !");
            }
        }

        private void dgvBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TableET tableET = new TableET(txtMaBan.Text.Trim(), txtTenBan.Text.Trim(), cbTang.Text.Trim(), cbTrangThaiBan.Text.Trim());

            if (banBus.SuaBan(tableET) != 0)
            {
                dgvBanAn.DataSource = banBus.DanhSachBan();
                MessageBox.Show("Sữa bàn thành công !");
            }
            else
            {
                MessageBox.Show("Sữa bàn thất bại !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TableET tableET = new TableET(txtMaBan.Text.Trim(), txtTenBan.Text.Trim(), cbTang.Text.Trim(), cbTrangThaiBan.Text.Trim());
            if (banBus.XoaBan(tableET) != 0)
            {
                dgvBanAn.DataSource = banBus.DanhSachBan();
                MessageBox.Show("Xóa bàn thành công !");
            }
            else
            {
                MessageBox.Show("Xóa bàn thất bại !");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTrangChu().Show();
            this.Close();
        }
    }
}
