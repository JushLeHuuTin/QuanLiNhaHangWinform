using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
        public int KienTraHoaDon(int idTable)
        {
            return HoaDonDAL.KiemTraHoaDon(idTable);
        }
        public int ThanhToan(int idHD, float thanhTien,string voucher)
        {
            return HoaDonDAL.ThanhToanHoaDon(idHD,thanhTien,voucher);
        }
        public int HuyHoaDon(int idHD)
        {
            return HoaDonDAL.HuyHoaDon(idHD);
        }
        public DataTable ThongkeHoaDon(DateTime dateTime1, DateTime dateTime2)
        {
            return HoaDonDAL.ThongkeHoaDon(dateTime1,dateTime2);
        }
    }
}
