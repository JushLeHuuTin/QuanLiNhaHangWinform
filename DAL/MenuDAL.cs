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
        public DataTable  HienThiCTHDByIdTable(TableET ban)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@MaBan",ban.MaBan)
            };
           return DataProvider.Instance.ExecuteQuery("sp_HienThiChiTietHoaDonTuIdBan",sqlParameters);
        }
    }
}
