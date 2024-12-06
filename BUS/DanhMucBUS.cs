using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhMucBUS
    {
        private static DanhMucDAL danhMucDAL = new DanhMucDAL();
        public static DataTable LoadDanhMuc()
        {
            return danhMucDAL.LoadDanhMuc();
        }
    }
}
