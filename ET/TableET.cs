using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class TableET
    {
        private int maBan;
        private string tenBan;
        private string trangThai;
        private string viTri;

        public TableET() { }
        public TableET(int maBan, string tenBan, string viTri, string trangThai)
        {
            this.maBan = maBan;
            this.tenBan = tenBan;
            this.trangThai = trangThai;
            this.viTri = viTri;
        }
        public TableET(DataRow item)
        {
            this.maBan = (int)item["Mã Bàn"];
            this.tenBan = (string)item["Tên bàn"];
            this.trangThai = (string)item["Trạng thái"];
            this.viTri = (string)item["Vị trí"];
        }
        public int MaBan { get => maBan; set => maBan = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string ViTri { get => viTri; set => viTri = value; }
    }
}
