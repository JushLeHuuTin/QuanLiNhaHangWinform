using BUS;
using ET;
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
    public partial class frmQLTaiKhoan : Form
    {
        TaiKhoanBUS dsTaiKhoanBus = new TaiKhoanBUS();
        public frmQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = dsTaiKhoanBus.LoadDSTaiKhoan();
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTaiKhoan.CurrentRow;
            txtTenTaiKhoan.Text = row.Cells[0].Value.ToString().Trim();
            txtTenHienThi.Text = row.Cells[1].Value.ToString().Trim();
            txtEmail.Text = row.Cells[2].Value.ToString().Trim();
            cbChucVu.Text = row.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoanET tk = new TaiKhoanET(txtTenTaiKhoan.Text.Trim(), txtTenHienThi.Text.Trim(), txtEmail.Text.Trim(), cbChucVu.Text);
            if (dsTaiKhoanBus.ThemTaiKhoan(tk) != 0)
            {
                dgvTaiKhoan.DataSource = dsTaiKhoanBus.LoadDSTaiKhoan();
                MessageBox.Show("Thêm tài khoản thành công.");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiKhoanET tk = new TaiKhoanET();
            tk.sID_NguoiDung = txtTenTaiKhoan.Text;
            if (dsTaiKhoanBus.XoaTaiKhoan(tk) != 0)
            {
                dgvTaiKhoan.DataSource = dsTaiKhoanBus.LoadDSTaiKhoan();
                MessageBox.Show("Xóa tài khoản thành công.");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoanET tk = new TaiKhoanET(txtTenTaiKhoan.Text.Trim(), txtTenHienThi.Text.Trim(), txtEmail.Text.Trim(), cbChucVu.Text);
            if (dsTaiKhoanBus.SuaTaiKhoan(tk) != 0)
            {
                dgvTaiKhoan.DataSource = dsTaiKhoanBus.LoadDSTaiKhoan();
                MessageBox.Show("Sửa tài khoản thành công.");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn resert mật khẩu ?","Resert mật khẩu",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                TaiKhoanET tk = new TaiKhoanET(txtTenTaiKhoan.Text.Trim(), txtTenHienThi.Text.Trim(), txtEmail.Text.Trim(), cbChucVu.Text);
                if (dsTaiKhoanBus.DatLaiMatKhau(tk) != -1)
                {
                    dgvTaiKhoan.DataSource = dsTaiKhoanBus.LoadDSTaiKhoan();
                    MessageBox.Show("resert tài khoản thành công.");
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại");
                }
            }
        }
    }
}
