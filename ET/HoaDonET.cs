using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class HoaDonET
    {
        private int idHD, idBan;
        private DateTime ngayTaoHD, ngayCheckout;
        private string codeVoucher;
        private string trangThai;
        private float thanhTien;

        public HoaDonET() { }
        public HoaDonET(int idHD, int idBan, DateTime ngayTaoHD, DateTime ngayCheckout, string codeVoucher, string trangThai,float thanhTien)
        {
            this.idHD = idHD;
            this.idBan = idBan;
            this.ngayTaoHD = ngayTaoHD;
            this.ngayCheckout = ngayCheckout;
            this.codeVoucher = codeVoucher;
            this.trangThai = trangThai;
            this.thanhTien = thanhTien;
        }

        public HoaDonET(DataRow item)
        {
            this.idHD = (int)item["ID_HoaDon"];
            this.idBan = (int)item["ID_Ban"];
            this.ngayTaoHD = (DateTime)item["NgayLap"];

            if (item["NgayCheckout"] != "")
            {
                this.ngayCheckout = ngayCheckout;
            }
            this.codeVoucher = codeVoucher;
            this.trangThai = trangThai;
            this.thanhTien = thanhTien;
        }
        public int IdHD { get => idHD; set => idHD = value; }
        public int IdBan { get => idBan; set => idBan = value; }
        public DateTime NgayTaoHD { get => ngayTaoHD; set => ngayTaoHD = value; }
        public DateTime NgayCheckout { get => ngayCheckout; set => ngayCheckout = value; }
        public string CodeVoucher { get => codeVoucher; set => codeVoucher = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
