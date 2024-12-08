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
using BUS;

namespace DoAnQLNhaHang
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        TaiKhoanET taikhoan = new TaiKhoanET();
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            taikhoan.sEmail = txt_tenNguoiDung_DN.Text;
            taikhoan.sMatKhau = txt_matKhau_DN.Text;
            string query = tkBUS.CheckDangNhap(taikhoan);
             
            switch (query)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tai khoản không được để trống!");
                    ShowError("Tai khoản không được để trống!");
                    return;
                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                case "Tài khoản đăng nhập không chính xác!":
                    MessageBox.Show("Tài khoản đăng nhập không chính xác!");
                    return;

            }
            // lấy loại tài khoản 
            TaiKhoanET taiKhoanET = tkBUS.getQuyenBUS(taikhoan);
            string loaitk = taiKhoanET.sLoaiTaiKhoan;
            taikhoan.sTenNguoiDung = taiKhoanET.sTenNguoiDung;
            Session.luuTT = taikhoan;
            switch (loaitk)
            {
                case "Admin":
                    MessageBox.Show($"Đăng nhập thành công! Quyền {loaitk}");
                    Session.luuTT = taikhoan;
                    frmHome adminForm = new frmHome();
                    adminForm.AdminAccess();
                    adminForm.Show();
                    this.Hide();
                    break;
                case "Nhân viên":
                    MessageBox.Show("Đăng nhập thành công");
                    Session.luuTT = taikhoan;
                    frmHome nhanVienForm = new frmHome();
                    nhanVienForm.QuyenNhanVien();
                    nhanVienForm.Show();
                    this.Hide();
                    break;
                case "Khách hàng":
                    MessageBox.Show("Đăng nhập thành công");
                    Session.luuTT = taikhoan;
                    frmHome khachHangForm = new frmHome();
                    khachHangForm.Qnguoidung();
                    khachHangForm.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Loại tài khoản không hợp lệ!");
                    break;
            }

          
        }

    

        private void btn_DangKy_DN_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            this.Hide();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        // cảnh báo đỏ
        private void ShowError(string message)
        {
            lbl_Error.Text = message;
            lbl_Error.ForeColor = Color.Red;
            lbl_Error.Visible = true;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_matKhau_DN.Text = "lehuutin";
            txt_tenNguoiDung_DN.Text = "tin@gmail.com";
        }
    }
}
