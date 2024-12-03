using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoucherDAL
    {
        public DataTable TimKiemVoucher(string code)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Code",code)
            };
            return DataProvider.Instance.ExecuteQuery("sp_TimkiemVoucher",sqlParameters);
        }

    }
}
