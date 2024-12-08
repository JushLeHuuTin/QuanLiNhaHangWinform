using ET;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{

    
    public  class TaiKhoanDAL
    {
        public static string CheckDangNhapDN(TaiKhoanET tk)
        {
            string user = null;
            try
            {
                string query = "sp_login";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@user", tk.sEmail),
                    new SqlParameter("@pass", tk.sMatKhau)
                };
                DataTable dt = DataProvider.Instance.ExecuteQuery(query, parameters);
                if( dt.Rows.Count > 0)
                {

                    user= dt.Rows[0][0].ToString();

                }
                else
                {
                    user= "Tài khoản đăng nhập không chính xác!";
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }


        public static string CheckDangDK(TaiKhoanET tk)
        {
            string user = null;
            try
            {
                string querry = "sp_singin";
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@ID_NguoiDung", tk.sID_NguoiDung),
                    new SqlParameter("@TenNguoiDung", tk.sTenNguoiDung),
                    new SqlParameter("@Email", tk.sEmail),
                    new SqlParameter("@MatKhau", tk.sMatKhau),
                    new SqlParameter("@LoaiTaiKhoan", tk.sLoaiTaiKhoan)
                };
                // khởi tạo bảng
                DataTable dt = DataProvider.Instance.ExecuteQuery(querry, parameters);
                if(dt.Rows.Count > 0)
                {
                    dt.Rows[0][0].ToString();

                    user = "Đăng ký thành công!";
                }
                else
                {
                    user = "Đăng ký không thành công!";
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }
       

        // check mật khảu cũ
        public static string CheckMatKhauCu(TaiKhoanET tk)
        {
         
            string user = null;
            try
            {

                string query = "sp_checkPassword";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@user",tk.sEmail),
                    new SqlParameter("@pass",tk.sMatKhau)
                };
                DataTable dt = DataProvider.Instance.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    user = dt.Rows[0][0].ToString();
                }
                else
                {
                    user = "Nhập mật khẩu sai!";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }
        //
        
        public static string CheckDangDoimatkhau(TaiKhoanET tk, string matkhaumoi)
        {
            string user = null;
            try
            {
                string query = "sp_moimatkhau";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@user", tk.sEmail),
                    new SqlParameter("@newpass", matkhaumoi)
                };

                // khởi tạo bảng
                int dt = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                if (dt > 0)
                {
                    //dt.Rows[0][0].ToString();
                    user = "Đổi mật khẩu thành công!";

                }
                else
                {
                    user = "Đổi mật khẩu không thành công!";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }

        // phân quyên tài khoan
        public static string upQuyen(TaiKhoanET tk)
        {
            string user = null;
            try
            {
                string query = "sp_upLoaiTaiKhoan";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Email", tk.sEmail),
                    new SqlParameter("@LoaiTaiKhoan", tk.sLoaiTaiKhoan)
                };

                // khởi tạo bảng
                int dt = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                if (dt > 0)
                {
                    //dt.Rows[0][0].ToString();
                    user = "Cập nhật phân quyền thành công!";

                }
                else
                {
                    user = "Cập nhật phân quyền không thành công!";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
            
        }
        //lay phan quyen 
        public static TaiKhoanET getPhanquyen(TaiKhoanET taiKhoan)
        {
            TaiKhoanET user = new TaiKhoanET();
            try
            {
                string querry = "sp_getLoaiTaiKhoan";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Email",taiKhoan.sEmail)
                };
                DataTable dt = DataProvider.Instance.ExecuteQuery(querry, parameters);
                if(dt.Rows.Count > 0)
                {
                    user.sLoaiTaiKhoan = dt.Rows[0][0].ToString();
                    user.sTenNguoiDung = dt.Rows[0][1].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }

        public static DataTable DSTaiKhoan()
        {
            return DataProvider.Instance.ExecuteQuery("sp_DSTaiKhoan");
        }
        public static int ThemTaiKhoan(TaiKhoanET tk)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ID_NguoiDung",tk.sID_NguoiDung),
                new SqlParameter("@TenNguoiDung",tk.sTenNguoiDung),
                new SqlParameter("@Email",tk.sEmail),
                new SqlParameter("@ChucVu",tk.sLoaiTaiKhoan)
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_ThemTaiKhoan", sp);
        }
        public static int SuaTaiKhoan(TaiKhoanET tk)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Id_ND",tk.sID_NguoiDung),
                  new SqlParameter("@TenND",tk.sTenNguoiDung),
                new SqlParameter("@Email",tk.sEmail),
                new SqlParameter("@ChucVu",tk.sLoaiTaiKhoan)
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_SuaTaiKhoan", sp);
        }
        public static int XoaTaiKhoan(TaiKhoanET tk)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@Id_ND",tk.sID_NguoiDung)
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_XoaTaiKhoan", sp);
        }

    }
}
