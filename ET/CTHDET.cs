using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class CTHDET
    {
        private int maCTHD, maHoaDon, maMonAn, soLuong;

        public CTHDET() { }

        public CTHDET(int maCTHD, int maHoaDon, int maMonAn, int soLuong)
        {
            this.maCTHD = maCTHD;
            this.maHoaDon = maHoaDon;
            this.maMonAn = maMonAn;
            this.soLuong = soLuong;
        }

        public int MaCTHD { get => maCTHD; set => maCTHD = value; }
        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaMonAn { get => maMonAn; set => maMonAn = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
