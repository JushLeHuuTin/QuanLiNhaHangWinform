using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAL HoaDonDAL = new HoaDonDAL();
        public bool CheckHoaDonByIdTable(int idTable)
        {
           return HoaDonDAL.checkHDByIdTable(idTable);
        }
        public int ThemHoaDon(int idTable)
        {
            return HoaDonDAL.ThemHoaDon(idTable);
        }
    }
}
