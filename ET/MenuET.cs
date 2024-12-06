using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class MenuET
    {
        private string tenMon;
        private float giaMon;
        private int soLuong;
        private float tongTien;

        public MenuET(string tenMon, float giaMon, int soLuong, float tongTien)
        {
            this.tenMon = tenMon;
            this.giaMon = giaMon;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
        }
        public MenuET(DataRow item)
        {
            this.tenMon = (string)item["tenMon"];
            this.giaMon = (float)(int)item["DonGia"];
            this.soLuong = (int)item["soLuong"];
            this.tongTien = (float)(int)item["tongTien"];
        }

        public string TenMon { get => tenMon; set => tenMon = value; }
        public float GiaMon { get => giaMon; set => giaMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }


    }
}
