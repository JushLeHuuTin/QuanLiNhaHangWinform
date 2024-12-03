using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class HoaDonET
    {
        private int idHD, idBan;
        private DateTime ngayTaoHD;
        private int tongTien;
        private string codeVoucher;
        private int giamGia, thanhTien;
        private string trangThai;

        public HoaDonET(int idHD, int idBan, DateTime ngayTaoHD, int tongTien, string codeVoucher, int giamGia, int thanhTien, string trangThai)
        {
            this.idHD = idHD;
            this.idBan = idBan;
            this.ngayTaoHD = ngayTaoHD;
            this.tongTien = tongTien;
            this.codeVoucher = codeVoucher;
            this.giamGia = giamGia;
            this.thanhTien = thanhTien;
            this.trangThai = trangThai;
        }

        public int IdHD { get => idHD; set => idHD = value; }
        public int IdBan { get => idBan; set => idBan = value; }
        public DateTime NgayTaoHD { get => ngayTaoHD; set => ngayTaoHD = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string CodeVoucher { get => codeVoucher; set => codeVoucher = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
