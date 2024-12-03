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
    public class HoaDonDAL
    {
        public Boolean checkHDByIdTable(int idTable)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaBan",idTable)
            };
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("sp_KiemTraHoaDon", sqlParameters); 
            if (dataTable.Rows.Count > 0) return true;
            else return false;
        }
        public int ThemHoaDon(int idTable)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter ("@MaBan",idTable)
            };
            return DataProvider.Instance.ExecuteNonQuery("ps_ThemHoaDon", sqlParameters);
        }
    }
}
