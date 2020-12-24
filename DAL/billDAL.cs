using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modesl;

namespace DAL
{
    public class billDAL
    {

        TBEntities s = new TBEntities();

        //保存
        public int Add(tb_bill rs) {
            int a = s.tb_bill.Where(p=>p.billno ==rs.billno).Count();

            if(a==0){
                s.tb_bill.Add(rs);
            }

            return s.SaveChanges();
        }

        public List<tb_bill> QueryAll(int pc) {
            return s.tb_bill.OrderByDescending(p=>p.billno).Skip(pc).Take(1).ToList();
        }

    }
}
