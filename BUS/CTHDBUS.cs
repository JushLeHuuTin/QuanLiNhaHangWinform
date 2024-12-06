using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTHDBUS
    {
        private static CTHDDAL CTHDDAL = new CTHDDAL();

        public static int ThemCTHD(CTHDET cTHDET)
        {
            return CTHDDAL.ThemCTHD(cTHDET);
        }
    }
}
