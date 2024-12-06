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
    public partial class frmQLThucDon : Form
    {
        QLMonAnBUS monAnBus = new QLMonAnBUS();
        public frmQLThucDon()
        {
            InitializeComponent();
        }

        private void frmQLThucDon_Load(object sender, EventArgs e)
        {
            dgvThucDon.DataSource = monAnBus.DanhSachMonAn();
            loadDanhMuc();

        }
        private void loadDanhMuc()
        {
            cbDanhMuc.DataSource = DanhMucBUS.LoadDanhMuc();
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "ID_DanhMuc";
            
        }
        private void dgvThucDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvThucDon.CurrentRow;
            txtMaMonAn.Text = row.Cells[0].Value.ToString().Trim();
            cbDanhMuc.Text = row.Cells[1].Value.ToString().Trim();  
            txtTenMonAn.Text = row.Cells[2].Value.ToString().Trim();
            txtDonGia.Text = row.Cells[3].Value.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonAnET monAn = new MonAnET(0,int.Parse(cbDanhMuc.SelectedValue.ToString()),txtTenMonAn.Text.Trim(),int.Parse(txtDonGia.Text.ToString()));
            //MonAnET monAn = new MonAnET(0,1,txtTenMonAn.Text.Trim(),50000);
            if(monAnBus.ThemMon(monAn) != -1)
            {
                dgvThucDon.DataSource = monAnBus.DanhSachMonAn();
                MessageBox.Show("Thêm món ăn thành công!");
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonAnET monAn = new MonAnET();
            monAn.MaMonAn = int.Parse(txtMaMonAn.Text);

            if (monAnBus.XoaMonAn(monAn) != 0)
            {
                dgvThucDon.DataSource = monAnBus.DanhSachMonAn();
                MessageBox.Show("Xóa món ăn thành công!");
            }
            else
            {
                MessageBox.Show("Xóa món ăn thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                MonAnET monAn = new MonAnET(int.Parse(txtMaMonAn.Text.Trim()),int.Parse(cbDanhMuc.SelectedValue.ToString()), txtTenMonAn.Text.Trim(),
                   int.Parse(txtDonGia.Text.Trim()));
                if (monAnBus.SuaMonAn(monAn) != 0)
                {
                    dgvThucDon.DataSource = monAnBus.DanhSachMonAn();
                    MessageBox.Show("Sửa món ăn thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa món ăn thất bại!");
                }

            }catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
