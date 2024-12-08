using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using ET;

namespace BUS
{
    public class QLBanBUS
    {
        BanDAL BanDAL = new BanDAL();
        //load ban
        public List<TableET> LoadBan()
        {
            List<TableET> list = new List<TableET>();
            DataTable dt = BanDAL.DanhSachBan();
           foreach (DataRow item in dt.Rows)
            {
                TableET t = new TableET(item);
                list.Add(t);
            }
            return list;
        }
        //hien thi ban
        public DataTable DanhSachBan()
        {
            return BanDAL.DanhSachBan();
        }
        //them ban
        public int ThemBan(TableET tableET)
        {
            return BanDAL.ThemBan(tableET);
        }
        //sua ban
        public int SuaBan(TableET tableET)
        {
            return BanDAL.SuaBan(tableET);
        }
        //sua trang thai ban
        public int SuaTrangThaiBan(TableET tableET)
        {
            return BanDAL.SuaBan(tableET);
        }
        //Xoa ban
        public int XoaBan(TableET tableET)
        {
            return BanDAL.XoaBan(tableET);
        }
        //Chuyen ban
        public int ChuyenBan(int idTable1,int idTable2)
        {
           return BanDAL.ChuyenBan(idTable1,idTable2);
        }
       
    }
}
