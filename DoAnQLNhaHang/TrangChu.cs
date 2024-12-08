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
using System.Globalization;
using System.Runtime.Remoting.Messaging;
namespace DoAnQLNhaHang
{
    public partial class frmTrangChu : Form
    {
        QLBanBUS QLBanBUS = new QLBanBUS();
        MenuBUS MenuBUS = new MenuBUS();
        QLMonAnBUS QLMonAnBUS = new QLMonAnBUS();
        VoucherBUS voucherBus = new VoucherBUS();
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            LoadBan();
            loadDanhMuc();
            loadBanCombo();
        }

        //hiển thị danh sách các bàn
        private void LoadBan()
        {
            List<TableET> list = QLBanBUS.LoadBan();
            flpTable.Controls.Clear();
            foreach (TableET item in list)
            {
                Button button = new Button();
                //add button vao flpTable
                // Đặt thuộc tính cho nút
                button.Text = item.TenBan + "\n" + item.TrangThai;
                button.Size = new Size(150, 80); // Kích thước nút
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
                        int idHoaDon = HoaDonBUS.KienTraHoaDon(item.MaBan);
                        if (idHoaDon != -1)
                        {
                            HoaDonBUS.HuyHoaDon(idHoaDon);

                        }
                        button.BackColor = Color.LightGreen;
                        break;
                }

                // Thêm sự kiện Click
                button.Click += Button_Click;
                button.Tag = item;
                button.ContextMenuStrip = CMSBan;
                // Thêm nút vào FlowLayoutPanel
                flpTable.Controls.Add(button);
            }
        }

        //Hiển thị danh sách danh mục vào combobox
        private void loadDanhMuc()
        {
            cbDanhMuc.DataSource = DanhMucBUS.LoadDanhMuc();
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "ID_DanhMuc";
        }

        //Hiển thị danh sách món ăn vào combobox
        private void loadMonAn(int idDanhMuc)
        {
            cbMonAn.DataSource = QLMonAnBUS.HienThiMonAnTuDanhMuc(idDanhMuc);
            cbMonAn.DisplayMember = "name";
            cbMonAn.ValueMember = "ID_MonAn";
        }

        //Load bàn vào combobox 
        private void loadBanCombo()
        {
            List<TableET> l = QLBanBUS.LoadBan();
            cbBan.DataSource = l;
            cbBan.DisplayMember = "TenBan";
            cbBan.ValueMember = "MaBan";
        }
        // Phương thức xử lý sự kiện Click khi click vào bàn
        private void Button_Click(object sender, EventArgs e)
        {
            TableET item = ((sender as Button).Tag as TableET);
            if (item != null)
            {
                lbSoBan.Tag = item;
                HienThiBanHienTai(item);
                ShowBill(item);
            } if (item.TrangThai != "Có người") resetForm();
            //txtVoucher_Leave(sender,e);
        }

        //hiện thị bàn hiện tại
        public void HienThiBanHienTai(TableET tableET)
        {
            lbSoBan.Text = tableET.TenBan.ToString();
            lbTrangThai.Text = tableET.TrangThai.ToString();
            lbViTri.Text = tableET.ViTri.ToString();
            if (tableET.TrangThai.Contains("Có người"))
                btnMoBan.Enabled = false;
            else btnMoBan.Enabled = true;
        }

        //show buill
        public void ShowBill(TableET tableET)
        {
            HienThiBanHienTai(tableET);
            lvCTHD.Items.Clear();
            List<MenuET> l = MenuBUS.HienThiMenuByIdTable(tableET);
            decimal tong = 0;
            foreach (MenuET item in l)
            {
                tong += Decimal.Parse(item.TongTien.ToString().Trim());
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.TenMon.ToString();
                listViewItem.SubItems.Add(item.SoLuong.ToString());
                listViewItem.SubItems.Add(item.GiaMon.ToString());
                listViewItem.SubItems.Add(item.TongTien.ToString());
                listViewItem.SubItems.Add(item.DanhMuc.ToString());
                lvCTHD.Items.Add(listViewItem);
            }
            if (tableET.TrangThai == "Có người")
            {
                txtTongTien.Text = tong.ToString();
                thanhTien();
            }
        }

        //Tính thành tiền
        private  bool thanhTien()
        {
            bool check = false;
            if (txtTongTien.Text != "")
            {
                DataTable dt = voucherBus.TimkiemVoucher(txtVoucher.Text.ToString());
                if(txtVoucher.Text == "") check = true;
                if (dt.Rows.Count > 0)
                {
                    txtGiamGia.Text = dt.Rows[0]["GiamGia"].ToString() + "%";
                    check = true;
                }
                else
                {
                    txtGiamGia.Text = "0";
                }

                string giam = txtGiamGia.Text.Split('%')[0];
                CultureInfo culture = new CultureInfo("vi-VN");
                txtThanhTien.Text = (Decimal.Parse(txtTongTien.Text) * (1 - Decimal.Parse(giam) / 100)).ToString("c", culture);
            }
            else { return true; }
             return check;
        }

        //Thực hiện mở bàn
        private void button2_Click(object sender, EventArgs e)
        {
            TableET tableET = (lbSoBan.Tag as TableET);
            if(tableET != null){

                if (MessageBox.Show("Bạn muốn mở " + tableET.TenBan, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    HoaDonBUS.ThemHoaDon(tableET.MaBan);

                    tableET.TrangThai = "Có người";
                    QLBanBUS.SuaBan(tableET);
                    HienThiBanHienTai(tableET);
                    LoadBan();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn muốn mở !");
            }
        }

        //Thêm món ăn 
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            TableET tableET = lbSoBan.Tag as TableET;
            if (tableET != null)
            {

                int maBan = tableET.MaBan;

                int idHoaDon = HoaDonBUS.KienTraHoaDon(tableET.MaBan);
                if (idHoaDon != -1)
                {
                    if (cbMonAn.SelectedItem != null)
                    {
                        CTHDET cTHDET = new CTHDET();
                        cTHDET.MaHoaDon = idHoaDon;
                        cTHDET.MaMonAn = (int)cbMonAn.SelectedValue;
                        cTHDET.SoLuong = (int)nupQuantity.Value;
                        if (cTHDET.SoLuong == 0)
                        {
                            MessageBox.Show("vui lòng chọn số lượng muốn thêm");
                        }
                        CTHDBUS.ThemCTHD(cTHDET);
                        ShowBill(tableET);

                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn món ăn !");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng mở bản trước khi thêm món");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn !");
            }

        }

        //nhấn thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            TableET tableET = lbSoBan.Tag as TableET;
            if (tableET != null)
            {
                int idHoaDon = HoaDonBUS.KienTraHoaDon(tableET.MaBan);
                if (idHoaDon != -1)
                {
                    if (thanhTien())
                    {
                        if (MessageBox.Show("Bạn muốn thanh toán cho " + tableET.TenBan, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            float thanhTien = 0;
                            string input = txtThanhTien.Text.Replace(",00 "," ").Split(' ')[0].Replace(",", "").Replace(".","");
                            float.TryParse(input, out thanhTien);
                            MessageBox.Show(thanhTien.ToString());
                            string voucher = "null";
                            if (txtVoucher.Text != "") voucher = txtVoucher.Text;
                            if (HoaDonBUS.ThanhToan(idHoaDon,thanhTien, voucher) != -1)
                            {
                                tableET.TrangThai = "Trống";
                                QLBanBUS.SuaBan(tableET);
                                LoadBan();
                                resetForm();
                                MessageBox.Show("Thanh toán thành công cho " + tableET.TenBan);
                            }
                            else MessageBox.Show("Thanh toan that bai");
                            ShowBill(tableET);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        private void resetForm()
        {
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            txtVoucher.Text = "";
        }
        private void qLMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLThucDon frmQLThucDon = new frmQLThucDon();
            frmQLThucDon.ShowDialog();
        }

        private void qLBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLBan frmQLBan = new frmQLBan();
            frmQLBan.Show();
            this.Hide();

        }

        private void btnBotMon_Click(object sender, EventArgs e)
        {
            ListViewItem i = lvCTHD.SelectedItems[0];

        }



        private void txtVoucher_Leave(object sender, EventArgs e)
        {
            if (!thanhTien())
            {
                MessageBox.Show("Voucher không tồn tại");
            }
        }
        //tinh thanh tien


        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = cbDanhMuc.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                int idDanhMuc = int.Parse(dataRow["ID_DanhMuc"].ToString());
                loadMonAn(idDanhMuc);

            }
        }

        private void nupQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnThemMon_Click(sender, e);
            }
        }

        private void txtVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!thanhTien())
                {
                    MessageBox.Show("Voucher không tồn tại");
                }

            }
        }

        private void huỷBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableET tableET = (lbSoBan.Tag as TableET);
            if (tableET != null)
            {
                int idTable = tableET.MaBan;
                int idHD = HoaDonBUS.KienTraHoaDon(idTable);
                if (idHD != -1)
                {
                    if (MessageBox.Show("Bạn có chắc hủy " + tableET.TenBan + " này ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                    {
                       if(HoaDonBUS.HuyHoaDon(idHD) != -1)
                        {
                            tableET.TrangThai = "Trống";
                            QLBanBUS.SuaBan(tableET);
                            LoadBan();
                            MessageBox.Show("Hủy bàn thành công");
                        }
                        else
                        {
                            MessageBox.Show("Vui long thanh toan hoa don truoc !");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn muốn huy !");
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            TableET table1 = lbSoBan.Tag as TableET;
            TableET table2 = cbBan.SelectedItem as TableET;
            if (table2.MaBan != table1.MaBan)
            {
                if(MessageBox.Show("Bạn có chắc muốn chuyển " + table1.TenBan +" sang " + table2.TenBan +"?", "Chuyển Bàn",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK){
                    QLBanBUS.ChuyenBan(table1.MaBan,table2.MaBan);
                    LoadBan();
                    ShowBill(lbSoBan.Tag as TableET);
                    MessageBox.Show("thanh cong");
                }

            }
        }

        private void lvCTHD_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvCTHD.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = (ListViewItem)lvCTHD.SelectedItems[0] ;
                cbDanhMuc.Text = listViewItem.SubItems[4].Text;
                cbMonAn.Text =  listViewItem.Text + " - "   + listViewItem.SubItems[2].Text;
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (lbSoBan.Tag as TableET != null)
            {
                if (HoaDonBUS.KienTraHoaDon((lbSoBan.Tag as TableET).MaBan) == -1)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xuất hóa đơn cho " + lbSoBan.Text + " ?", "In hóa đơn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Form frm = new frmReport((lbSoBan.Tag as TableET).MaBan);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng thanh toán trước khi xuất hóa đơn !");
                }

            }

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThongke = new ThongKeHoaDon();
            frmThongke.ShowDialog();
        }
    }
}