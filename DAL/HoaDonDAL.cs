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
            return DataProvider.Instance.ExecuteNonQuery("sp_TaoHoaDon", sqlParameters);
        }
        public int KiemTraHoaDon(int idTable)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter ("@MaBan",idTable)
            };
            DataTable  dt = DataProvider.Instance.ExecuteQuery("sp_KiemTraHoaDon", sqlParameters);
            if (dt.Rows.Count > 0)
            {
                HoaDonET hoaDonET = new HoaDonET(dt.Rows[0]);
                return hoaDonET.IdHD;
            }
            return -1;
        }
        public int ThanhToanHoaDon(int idHD)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter ("@MaHD",idHD)
            };
           return DataProvider.Instance.ExecuteNonQuery("sp_ThanhToan", sqlParameters);
        }
    }
}
