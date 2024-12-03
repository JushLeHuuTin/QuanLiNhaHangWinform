using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;
using BUS;
namespace DoAnQLNhaHang
{
    public partial class frmTrangChu : Form
    {
        QLBanBUS QLBanBUS = new QLBanBUS();
        MenuBUS CTHDBUS = new MenuBUS();
        QLMonAnBUS QLMonAnBUS = new QLMonAnBUS();
        VoucherBUS voucherBus = new VoucherBUS();
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private void LoadBan()
        {
            List<TableET> list = QLBanBUS.LoadBan();
            foreach (TableET item in list)
            {
                Button button = new Button();
                //add button vao flpTable
                // Đặt thuộc tính cho nút
                button.Text = item.TenBan + "\n" + item.TrangThai;
                button.Size = new Size(100, 50); // Kích thước nút
                button.Margin = new Padding(5); // Khoảng cách giữa các nút
                switch (item.TrangThai)
                {
                    case "Có người":
                        button.BackColor = Color.CadetBlue;
                        break;
                    case "Đặt trước":
                        button.BackColor = Color.LightYellow;
                        break;
                    default:
                        button.BackColor = Color.LightGreen;
                        break;
                }

                // Thêm sự kiện Click
                button.Click += Button_Click;
                button.Tag = item;
                // Thêm nút vào FlowLayoutPanel
                flpTable.Controls.Add(button);
            }
        }
        private void LoadMonAn()
        {
            DataTable dt = QLMonAnBUS.DanhSachMonAn();
            dgvDSMonAn.DataSource = dt;
            dgvDSMonAn.Columns.Remove("id_MonAn");
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadMonAn();

        }
        // Phương thức xử lý sự kiện Click
        private void Button_Click(object sender, EventArgs e)
        {
            (sender as Button).Select();
            dgvCTHD.Tag = (sender as Button).Tag;
            // Ép kiểu sender về TableET
            TableET item = ((sender as Button).Tag as TableET);
            if (item != null)
            {
                lbSoBan.Text = item.TenBan.ToString();
                lbSoBan.Tag = item;
                lbTrangThai.Text = item.TrangThai.ToString();
                ShowBill(item);

                txtGiamGia.Text = "";
                txtVoucher.Text = "";
                txtThanhTien.Text = "";
            }
        }
        //show buill
        public void ShowBill(TableET tableET)
        {
                
            DataTable dataTable = CTHDBUS.HienThiCTHDByIdTable(tableET);
            decimal tong = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tong += Decimal.Parse(dataRow["TongTien"].ToString().Trim());
            }
            dgvCTHD.DataSource = dataTable;
            txtTongTien.Text = tong.ToString();
        }

        private void qLMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLThucDon frmQLThucDon = new frmQLThucDon();
            frmQLThucDon.ShowDialog();
            this.Hide();
        }

        private void qLBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLBan frmQLBan = new frmQLBan();
            frmQLBan.Show();
            this.Hide();
            
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableET tableET = (lbSoBan.Tag as TableET);
            tableET.TrangThai = "Có người";
            QLBanBUS.SuaBan(tableET);
            lbTrangThai.Text = tableET.TrangThai;
            flpTable.Controls.Clear();
            frmTrangChu_Load(sender,e);

          
        }

        private void btnBotMon_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvCTHD.CurrentRow;
            if (dataGridViewRow != null) { 
                
            }
        }

        private void txtGiamGia_Leave(object sender, EventArgs e)
        {


        }

        private void txtVoucher_Leave(object sender, EventArgs e)
        {
            if (txtTongTien.Text != "")
            {
                DataTable dt = voucherBus.TimkiemVoucher(txtVoucher.Text.ToString());
                if (dt.Rows.Count > 0)
                {
                    txtGiamGia.Text = dt.Rows[0]["GiamGia"].ToString()+"%";
                }
                else
                {
                    txtGiamGia.Text = "0";
                }

                string giam = txtGiamGia.Text.Split('%')[0];
                txtThanhTien.Text = (Decimal.Parse(txtTongTien.Text) * (1 - Decimal.Parse(giam) / 100)).ToString("c");
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            TableET tableET = dgvCTHD.Tag as TableET;
            if (!HoaDonBUS.CheckHoaDonByIdTable(tableET.MaBan))
            {
                HoaDonBUS.ThemHoaDon(tableET.MaBan);
            }
            else
            {

            }

        }
    }
}