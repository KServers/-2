using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modesl;
using DAL;

namespace BLL
{
    public class billBLL
    {
        billDAL s = new billDAL();

        public int Add(tb_bill rs) {
            return s.Add(rs);
        }

        public List<tb_bill> QueryAll(int pc) {
            return s.QueryAll(pc);
        }


    }
}
