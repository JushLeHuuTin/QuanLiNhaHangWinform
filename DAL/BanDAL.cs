using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using ET;

namespace DAL
{
    public class BanDAL
    {
        public SqlConnection Connection;
        public BanDAL() { }
        //hien thi ban an
        public DataTable DanhSachBan()
        {
            return DataProvider.Instance.ExecuteQuery("sp_DanhSachBan");
        }
        public int ThemBan(TableET ban)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
             
                new SqlParameter("@TenBan",ban.TenBan),
                new SqlParameter("@ViTri",ban.ViTri),
                new SqlParameter("@TrangThai",ban.TrangThai),
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_ThemBan", sqlParameters);
        }
        public int SuaBan(TableET ban)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaBan",ban.MaBan),
                new SqlParameter("@TenBan",ban.TenBan),
                new SqlParameter("@ViTri",ban.ViTri),
                new SqlParameter("@TrangThai",ban.TrangThai),
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_SuaBan", sqlParameters);
        }

        public int SuaTrangThaiBan(TableET ban)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                    new SqlParameter("@MaBan",ban.MaBan),
                    new SqlParameter("@TrangThai",ban.TrangThai),
             };
            return DataProvider.Instance.ExecuteNonQuery("sp_SuaTrangThaiBan", sqlParameters);
        }
        //xoa ban
        public int XoaBan(TableET ban)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaBan",ban.MaBan)
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_XoaBan", sqlParameters);
        }    
    }
}
