using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DAL
{
    public class CTHDDAL
    {
        public int ThemCTHD(CTHDET cTHDET)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] { 
                new SqlParameter("@MaHD",cTHDET.MaHoaDon),
                new SqlParameter("@MaMonAn",cTHDET.MaMonAn),
                new SqlParameter("@SoLuong",cTHDET.SoLuong)
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_ThemCTHD", sqlParameters);
        }
    }
}
