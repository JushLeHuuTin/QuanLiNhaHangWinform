using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Voucher
    {
        private int code;
        private string moTa;
        private int phanTram;
        private string loaiMa;
        private int soLuong, diem;

        public Voucher()
        {
          
        }

        public Voucher(int code, string moTa, int phanTram, string loaiMa, int soLuong, int diem)
        {
            this.code = code;
            this.moTa = moTa;
            this.phanTram = phanTram;
            this.loaiMa = loaiMa;
            this.soLuong = soLuong;
            this.diem = diem;
        }

        public int Code { get => code; set => code = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int PhanTram { get => phanTram; set => phanTram = value; }
        public string LoaiMa { get => loaiMa; set => loaiMa = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}
