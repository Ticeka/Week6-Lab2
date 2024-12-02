using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleApi.Models;

namespace GoogleApi.Controllers
{
    public class PieChartController : Controller
    {
        // GET: PieChart
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetDataJson()
        {
            var db = new Database1Entities();
            var data = db.Sales.Select(s => new { ProductName = s.ProductName, Sales = s.Sales }).ToList();

            return Json(new { JSONList = data }, JsonRequestBehavior.AllowGet);
        }

    }
}