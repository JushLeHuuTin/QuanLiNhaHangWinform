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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        TaiKhoanET taikhoan;
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            //lấy thông tin tài khoản đã lưu sau khi đăng nhập
            taikhoan = Session.luuTT;
        
           string mkcu = txt_matkhauhientai.Text;
            //MessageBox.Show(mkcu );
            string mkmoi = txt_matKhauMoi.Text;
            string nhaplaimkm = txt_nhapLaiMatKhauMoi.Text;
            //MessageBox.Show($"cu: {mkcu} mới: {mkmoi}  lai: {nhaplaimkm}");
            try
            {
                string querry = tkBUS.CheckDoimatkhauBUS(taikhoan,mkcu, mkmoi, nhaplaimkm);
                switch (querry)
                {
                    case "requeid_passwordCu":
                        MessageBox.Show("Vui lòng nhập mật khẩu cũ đúng!");
                        return;
                    case "requeid_password":
                        MessageBox.Show("Mật khẩu mới phải có độ dài từ 6-24 ký tự!");
                        return;
                    case "requeid_passwordnew":
                        MessageBox.Show("Mật khẩu nhập lại không chính xác!");
                        return;

                }
                MessageBox.Show("Đổi mật khẩu thành công!");
                // chuyển sang màn hình đăng nhập
                frmTrangChu cn = new frmTrangChu();
                cn.Show();
                this.Hide();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void frmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                e.Cancel = false;
                frmTrangChu tc = new frmTrangChu();
                tc.Show();
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_QuayLai_DK_Click(object sender, EventArgs e)
        {
            frmTrangChu tc = new frmTrangChu();
            
            this.Hide();
        }
    }
}
