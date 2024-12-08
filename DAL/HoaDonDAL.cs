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
        public int ThanhToanHoaDon(int idHD,float thanhTien,string voucher)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter ("@MaHD",idHD),
                    new SqlParameter ("@ThanhTien",thanhTien),
                    new SqlParameter ("@Voucher",voucher)
            };
           return DataProvider.Instance.ExecuteNonQuery("sp_ThanhToan", sqlParameters);
        }
        public int HuyHoaDon(int idHD)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter ("@MaHD",idHD)
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_HuyHoaDon", sqlParameters);
        }
       public DataTable ThongkeHoaDon(DateTime dateTime1, DateTime dateTime2)
        {
            return DataProvider.Instance.ExecuteQuery("sp_ThongKeHoaDon",new SqlParameter[] { new SqlParameter("@DateStart",dateTime1),new SqlParameter("@DateEnd",dateTime2)});
        }
        public DataTable ThongkeHoaDonChoBaoCao(DateTime dateTime1, DateTime dateTime2)
        {
            return DataProvider.Instance.ExecuteQuery("sp_ThongKeHoaDonChoBaoCao", new SqlParameter[] { new SqlParameter("@DateStart", dateTime1), new SqlParameter("@DateEnd", dateTime2) });
        }
    }
}
