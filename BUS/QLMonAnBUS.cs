using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLMonAnBUS
    {
        MonAnDAL MonAnDAL = new MonAnDAL();

        public List<MonAnET> GetListMonAn()
        {
            return MonAnDAL.GetListMonAn();
        }
        //Hien danh sach mon an
        public DataTable DanhSachMonAn()
        {
            return MonAnDAL.DSMonAn();
        }
        //hien thi mon an theo danh muc
        public DataTable HienThiMonAnTuDanhMuc(int maDanhMuc){
            return MonAnDAL.HienThiMonAnTuDanhMuc(maDanhMuc);
        }
        //Them mon an
        public int ThemMon(MonAnET monAnET)
        {
            return MonAnDAL.ThemMon(monAnET);
        }
        //Xoa mon an
        public int XoaMonAn(MonAnET monAnET)
        {
            return MonAnDAL.XoaMon(monAnET);
        }
        //Sua mon an
        public int SuaMonAn(MonAnET monAnET)
        {
            return MonAnDAL.SuaMon(monAnET);
        }
    }
}
