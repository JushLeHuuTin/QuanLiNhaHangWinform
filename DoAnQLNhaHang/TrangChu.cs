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
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            List<TableET> list = QLBanBUS.LoadBan();
            int tongSoBan = int.Parse(QLBanBUS.TongSoBan().ToString());
            foreach (TableET item in list)
            {
                Button button = new Button();
                //add button vao flpTable
                // Đặt thuộc tính cho nút
                button.Text = item.TenBan + "\n" + item.TrangThai;
                button.Size = new Size(100, 50); // Kích thước nút
                button.Margin = new Padding(5); // Khoảng cách giữa các nút
                if (item.TrangThai == "Đang sử dụng") { button.BackColor = Color.BlueViolet; }
                else button.BackColor = Color.White;    
                
                // Thêm sự kiện Click
                button.Click += Button_Click;
                button.Tag = item;
                // Thêm nút vào FlowLayoutPanel
                flpTable.Controls.Add(button);
            }
        }
        // Phương thức xử lý sự kiện Click
        private void Button_Click(object sender, EventArgs e)
        {
            // Ép kiểu sender về TableET
            TableET item = ((sender as Button).Tag as TableET);
            if (item != null)
            {
                lbSoBan.Text = item.TenBan.ToString();
                lbSoBan.Tag = item;
                MessageBox.Show(item.TenBan);
                lbTrangThai.Text = item.TrangThai.ToString();

            }
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
            
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableET tableET = (lbSoBan.Tag as TableET);
            tableET.TrangThai = "Đang sử dụng";
            QLBanBUS.SuaBan(tableET);
            flpTable.Controls.Clear();
            frmTrangChu_Load(sender,e);
        }
    }
}