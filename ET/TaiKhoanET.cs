using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public  class TaiKhoanET
    {
        public string sID_NguoiDung { get; set; }
        public string sTenNguoiDung { get; set; }
        public string sEmail { get; set; }
        public string sMatKhau { get; set; }  
        public string sLoaiTaiKhoan { get; set; }

        public TaiKhoanET() { }

        public TaiKhoanET(string sID_NguoiDung, string sTenNguoiDung, string sEmail, string sLoaiTaiKhoan)
        {
            this.sID_NguoiDung = sID_NguoiDung;
            this.sTenNguoiDung = sTenNguoiDung;
            this.sEmail = sEmail;
            this.sLoaiTaiKhoan = sLoaiTaiKhoan;
        }
    }

    // lưu thông tin đăng nhập
    public static class Session
    {
        public static TaiKhoanET luuTT { get; set; }
        
    }
        
}
