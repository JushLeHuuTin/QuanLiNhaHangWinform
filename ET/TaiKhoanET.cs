using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class TaiKhoanET
    {
        private static TaiKhoanET instance;

        private string maTaiKhoan, tenTaiKhoan, email, matKhau, loaiTaiKhoan;

        public static TaiKhoanET Instance { 
            get {    
                if(instance == null) instance = new TaiKhoanET();
                         return instance;
            }
            set => instance = value; }

        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
    }
}
