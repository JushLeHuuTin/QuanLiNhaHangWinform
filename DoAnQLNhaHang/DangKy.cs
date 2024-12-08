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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        TaiKhoanET taikhoan = new TaiKhoanET();
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            taikhoan.sID_NguoiDung = txt_IDnguoidung.Text;
            taikhoan.sTenNguoiDung = txt_tenNguoiDung_DK.Text;
            taikhoan.sEmail = txt_sEmail_DK.Text;
            taikhoan.sMatKhau = txt_matKhau_DK.Text;
            string nhaplaimatkhau = txt_nhapLaiMatKhau_DK.Text;
            taikhoan.sLoaiTaiKhoan = cb_LoaiTK.Text;
            try
            {
            string query = tkBUS.CheckDangKy(taikhoan,nhaplaimatkhau);
                MessageBox.Show(query);

            switch (query)
            {
                case "requeid_ID":
                    MessageBox.Show("Vui lòng nhập tên id !");
                    return;
                    
                    case "requeid_tenNDung":
                    MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, chữ hoa và chữ thường!");
                    return;
                    
                    case "requeid_email":
                    MessageBox.Show("Vui lòng nhập đúng định dạng của email!");
                    return;

                case "requeid_password":
                    MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ số, chữ hoa và chữ thường!");
                    return;
                case "requeid_Renertpassword":
                    MessageBox.Show("Vui lòng nhập lại mật khẩu chính xác!");
                    return;
                case "requeid_loaitaikhoan":
                    MessageBox.Show("Vui lòng chọn loại tài khoàn!");
                    return;
            }
                MessageBox.Show(taikhoan.sEmail);
                    MessageBox.Show("Đăng ký thành công!");
                    // chuyển sang màn hình đăng nhập
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.Show();
                    this.Hide();
                  
               
                  
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }

        private void btn_DangNhap_DK_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
            this.Hide();
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
        }

      

    }


}

