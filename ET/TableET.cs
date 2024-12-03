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
        private string maBan;
        private string tenBan;
        private string trangThai;
        private string tang;

        public TableET() { }
        public TableET(string maBan, string tenBan, string tang, string trangThai)
        {
            this.maBan = maBan;
            this.tenBan = tenBan;
            this.trangThai = trangThai;
            this.tang = tang;
        }
        public TableET(DataRow item)
        {
            this.maBan = (string)item["ID_BAN"].ToString();
            this.tenBan = (string)item["tenBan"];
            this.trangThai = (string)item["trangThai"];
            this.tang = (string)item["ViTri"];
        }
        public string MaBan { get => maBan; set => maBan = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string Tang { get => tang; set => tang = value; }
    }
}
