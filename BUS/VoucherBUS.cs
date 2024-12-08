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
    public class VoucherBUS
    {
        VoucherDAL VoucherDAL = new VoucherDAL();
        public DataTable TimkiemVoucher(string code)
        {
            return VoucherDAL.TimKiemVoucher(code);
        }
    }
}
