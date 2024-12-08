using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class MonAnDAL
    {
        public SqlConnection conn;
        
        public MonAnDAL()
        {
        }

        public List<MonAnET> GetListMonAn()
        {
            List<MonAnET> monAnETs = new List<MonAnET>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("sp_DSMonAn");
            foreach (DataRow item in dt.Rows)
            {
                monAnETs.Add(new MonAnET(item));
            }
            return monAnETs;
        }
        //Hien thi mon an
        public DataTable DSMonAn()
        {
            return DataProvider.Instance.ExecuteQuery("sp_DSMonAn");
            
        }
        public DataTable DSMonAnchoBaoCao()
        {
            return DataProvider.Instance.ExecuteQuery("sp_DSMonAnchoBaoCao");

        }
        //Hien thi mon an tu ma danh muc
        public DataTable HienThiMonAnTuDanhMuc(int maDanhMuc)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@MaDanhMuc", maDanhMuc) };
            return DataProvider.Instance.ExecuteQuery("sp_HienThiMonAnTuDanhMuc",sqlParameters);
        }
        //Them mon an
        public int ThemMon(MonAnET monAn)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] { 
                new SqlParameter("@TenMon", monAn.TenMonAn),
                new SqlParameter("@DonGia", monAn.DonGia),
                new SqlParameter("@DanhMuc", monAn.MaDanhMuc)
                
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_ThemMonAn",sqlParameters);
        }
        //Xoa mon
        public int XoaMon(MonAnET monAn)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@MaMon", monAn.MaMonAn)

            };
            return DataProvider.Instance.ExecuteNonQuery("sp_XoaMon", sqlParameters); ;
        }
        //Sua mon
        public int SuaMon(MonAnET monAn)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@MaMon", monAn.MaMonAn),
                new SqlParameter("@TenMon", monAn.TenMonAn),
                new SqlParameter("@DonGia", monAn.DonGia),
                new SqlParameter("@DanhMuc", monAn.MaDanhMuc)

            };
            return DataProvider.Instance.ExecuteNonQuery("sp_SuaMon", sqlParameters);
        }
        //tim kiem mon an
        public DataTable TimKiemMuonAn(string Key)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@name",Key) };
            return DataProvider.Instance.ExecuteQuery("sp_TimKiemMonAn", sqlParameters);
        }

    }
}
