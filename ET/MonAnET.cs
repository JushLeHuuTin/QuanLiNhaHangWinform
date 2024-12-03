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
        private int maMonAn;
        private string tenMonAn;
        private int donGia;
        private string trangThai;

        public MonAnET(int maMonAn, string tenMonAn, int donGia, string trangThai)
        {
            this.MaMonAn = maMonAn;
            this.TenMonAn = tenMonAn;
            this.DonGia = donGia;
            this.TrangThai = trangThai;
        }

        public MonAnET(DataRow item)
        {
            this.MaMonAn = (int)item["ID_MonAn"];
            this.TenMonAn = (string)item["TenMon"];
            this.DonGia = (int)item["donGia"];
            this.TrangThai = (string)item["TrangThai"];
        }
        public int MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
