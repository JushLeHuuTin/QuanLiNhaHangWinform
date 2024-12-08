using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.TaiKhoanDAL;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public string CheckDangNhap(TaiKhoanET taikhoan)
        {
            
            // kiem tra
            if (!checkEmail(taikhoan.sEmail))
            {
                return "requeid_taikhoan";
            }
            if (taikhoan.sMatKhau == "")
            {
                return "requeid_password";
            }
            string info = TaiKhoanDAL.CheckDangNhapDN(taikhoan);
            return info;
        }

      
        public bool checkAccounnt(string Acc)
        {
            return Regex.IsMatch(Acc, "^[a-zA-Z0-9]{6,24}$");
        }


        public bool checkAccounnt1(string Acc)
        {
            return Regex.IsMatch(Acc, @"^[a-zA-Z\s]{6,24}$");
        }

        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9._%+-]+@(gmail\.com|example\.com|[\w-]+\.(com|vn))$");
        }
        public string CheckDangKy(TaiKhoanET taiKhoan, string nhaplaimatkhau)

        {
            if(taiKhoan.sID_NguoiDung == "")
            {
                return "requeid_ID";

            } 
            if(!checkAccounnt1(taiKhoan.sTenNguoiDung))
            {
                return "requeid_tenNDung";

            }
            if (!checkEmail(taiKhoan.sEmail))
            {
                return "requeid_email";
            }
            if (!checkAccounnt(taiKhoan.sMatKhau))
            {
                return "requeid_password";
            }
            if (nhaplaimatkhau != taiKhoan.sMatKhau)
            {
                return "requeid_Renertpassword";
            } 
            if (taiKhoan.sLoaiTaiKhoan == "")
            {
                return "requeid_loaitaikhoan";
            }
            
            string info = TaiKhoanDAL.CheckDangDK(taiKhoan);
            return info;
            
        }

        public string CheckDoimatkhauBUS(TaiKhoanET taiKhoan,string mkcu, string matKhauMoi, string nhaplaimatkhau)
        {
            string checkMKcu = TaiKhoanDAL.CheckMatKhauCu(taiKhoan);
           
            if (checkMKcu != mkcu)
            {
                return "requeid_passwordCu";
            }

            if (!checkAccounnt(matKhauMoi))
            {
                return "requeid_password";

            }
      
            if (nhaplaimatkhau !=matKhauMoi)
            {
                return "requeid_passwordnew";
            }


            string info = TaiKhoanDAL.CheckDangDoimatkhau (taiKhoan,matKhauMoi);
            return info;
        }

        // phân quyền
        public string upQuyenBUS(TaiKhoanET taiKhoan)
        {
            //kiểm tra
            if(taiKhoan.sEmail == "")
            {
                return "requeid_emailqu";
            }
            if (taiKhoan.sLoaiTaiKhoan == "")
            {
                return "requeid_loaiTK";
            }

            string info = TaiKhoanDAL.upQuyen(taiKhoan);
            return info;
        }


        public TaiKhoanET getQuyenBUS(TaiKhoanET taiKhoan)
        {

            return TaiKhoanDAL.getPhanquyen(taiKhoan);
        }

        public DataTable LoadDSTaiKhoan()
        {
            return TaiKhoanDAL.DSTaiKhoan();
        }
        public int ThemTaiKhoan(TaiKhoanET tk)
        {
            return TaiKhoanDAL.ThemTaiKhoan(tk);
        }
        public int SuaTaiKhoan(TaiKhoanET tk)
        {
            return TaiKhoanDAL.SuaTaiKhoan(tk);
        }
        public int XoaTaiKhoan(TaiKhoanET tk)
        {
            return TaiKhoanDAL.XoaTaiKhoan(tk);
        }
        //dat lai mk
        public int DatLaiMatKhau(TaiKhoanET tk)
        {
            return TaiKhoanDAL.DatLaiMatKhau(tk);
        }
    }
}
