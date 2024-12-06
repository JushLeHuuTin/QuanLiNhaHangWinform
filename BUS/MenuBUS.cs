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
    public class MenuBUS
    {
        MenuDAL cTHDDAL = new MenuDAL();
        public MenuBUS() { }
        public List<MenuET> HienThiMenuByIdTable(TableET tableET)
        {
           return cTHDDAL.HienThiMenuByIdTable(tableET);
        }
    }
}
