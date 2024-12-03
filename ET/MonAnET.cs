using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class MonAnET
    {
        private string maMonAn;
        private string tenMonAn;
        private int donGia;
        private string trangThai;

        public MonAnET(string maMonAn, string tenMonAn, int donGia, string trangThai)
        {
            this.MaMonAn = maMonAn;
            this.TenMonAn = tenMonAn;
            this.DonGia = donGia;
            this.TrangThai = trangThai;
        }

        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
