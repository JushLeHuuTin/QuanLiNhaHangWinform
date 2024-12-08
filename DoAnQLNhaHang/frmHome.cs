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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            loadName();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ShowForm(new frmTrangChu());
            Label label = new Label();
            label.Height = 1;
            label.Width = 20;
            label.BackColor = Color.Black;
            label.Dock = DockStyle.Top;
            panel2.Controls.Add(label);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmTrangChu frmTrangChu = new frmTrangChu();
            ShowForm(frmTrangChu);


        }
        private void ShowForm(Form from){
            pnPrimary.Controls.Clear();
            from.TopLevel = false;
            from.FormBorderStyle = FormBorderStyle.None;
            from.Dock = DockStyle.Fill;

            pnPrimary.Controls.Add(from);
            from.Show();
        }
        public void AdminAccess()
        {
            ////
            btnAdmin.Enabled = true;

        }

        public void QuyenNhanVien()
        {
            // Cho phép tất cả các quyền và chức năng dành cho Admin
            //Mnu_Baocao.Visible = true;
            //Mnu_DangXuat.Visible = true;
            //Mnu_Admin.Visible = false;
            btnAdmin.Enabled = false;
        }

        public void Qnguoidung()
        {
            // Cho phép tất cả các quyền và chức năng dành cho Admin
            //Mnu_Baocao.Visible = false;
            //Mnu_DangXuat.Visible = true;
            //Mnu_Admin.Visible = false;
            btnAdmin.Enabled= false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("dd/MM/yyyyy HH:mm:ss");
        }
        //Load Name
        private void loadName()
        {
            lblName.Text = Session.luuTT.sTenNguoiDung;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowForm(new Admin());
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            ShowForm(new frmDoiMatKhau());

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.luuTT = null;
                DangNhap formDangNhap = new DangNhap();
                formDangNhap.Show();
                this.FormClosing -= frmHome_FormClosing;

                this.Close();

                this.FormClosing += frmHome_FormClosing;
            }
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
