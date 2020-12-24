using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modesl;
using BLL;

namespace UI.Controllers
{
    public class billController : Controller
    {
        //
        // GET: /bill/

        billBLL s = new billBLL();


        public ActionResult Index()
        {
            return View();
        }


        //服务器端查询
        public ActionResult FWQ(int pc) {
            List<tb_bill> list = s.QueryAll(pc);

            var obj = list.Select(p => new
            {
                billno = p.billno,
                billdate = p.billdate.ToString("yyyy-MM-dd"),
                suppliername = p.suppliername,
                supplieraddress = p.supplieraddress,
                department = p.department,
                warehouse = p.warehouse,
                buyer = p.buyer,
                executor = p.executor,
                datalist = p.tb_detail.Select(q => new {
                qbillno = q.billno,
                qlineid = q.lineid,
                qgoodsname = q.goodsname,
                qgoodsnum = q.goodsnum,
                qgoodsprice = q.goodsprice,
                qgoodsmoneyamt = q.goodsmoneyamt,
                qispresent = q.ispresent
                })
            });


            return Json(obj,JsonRequestBehavior.AllowGet);
        }

    }
}
