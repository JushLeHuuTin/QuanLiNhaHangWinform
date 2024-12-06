using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class MonAnET
    {
        private int maMonAn, maDanhMuc;
        private string tenMonAn;
        private int donGia;

        public MonAnET()
        {
        }

        public MonAnET(DataRow item)
        {
            this.MaMonAn = (int)item["ID_MonAn"];
            this.TenMonAn = (string)item["TenMon"];
            this.DonGia = (int)item["donGia"];
            this.MaDanhMuc = (int)item["ID_DanhMuc"];
        }

        public MonAnET(int maMonAn, int maDanhMuc, string tenMonAn, int donGia)
        {
            this.maMonAn = maMonAn;
            this.maDanhMuc = maDanhMuc;
            this.tenMonAn = tenMonAn;
            this.donGia = donGia;
        }

        public int MaMonAn { get => maMonAn; set => maMonAn = value; }
        public int MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public int DonGia { get => donGia; set => donGia = value; }
    }
}
