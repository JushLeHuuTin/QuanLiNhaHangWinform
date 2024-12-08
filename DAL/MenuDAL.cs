using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDAL
    {
        public MenuDAL() { }
        public List<MenuET>  HienThiMenuByIdTable(TableET ban)
        {
            List<MenuET> l = new List<MenuET>();
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@MaBan",ban.MaBan)
            };
           DataTable dt = DataProvider.Instance.ExecuteQuery("sp_HienThiChiTietHoaDonTuIdBan",sqlParameters);
            foreach (DataRow dr in dt.Rows) {
                l.Add(new MenuET(dr));
            }
            return l;
        }
        public DataTable InHoaDon(TableET ban)
        {
            List<MenuET> l = new List<MenuET>();
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@idBan",ban.MaBan)
            };
            return DataProvider.Instance.ExecuteQuery("sp_InHoaDon", sqlParameters);
           
        }
    }
}
