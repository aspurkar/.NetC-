using MvcJSONData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcJSONData.Controllers
{
    public class HomeController : Controller
    {
        List<Customer> customers = null;
        public HomeController()
        {
            customers = new List<Customer>();
            for (int i = 0; i < 5; i++)
            {
                customers.Add(new Customer() {
                CustomerId=1001+i,
                Name="Name "+i,
                Email="customer"+i+"@yahoo.com",
                Mobile="843554590"+i+i
                });
            }
        }

        public ActionResult Index()
        {
            return View(customers);
        }
        public ActionResult Details(int customerid)
        {
            var cust = customers.Where(c => c.CustomerId == customerid).FirstOrDefault();
            if (cust != null)
            {
                return Json(cust, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { msg = "Customer with specified id not found" }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult Details2(int customerid)
        {
            var cust = customers.Where(c => c.CustomerId == customerid).FirstOrDefault();
            if (cust != null)
            {
                return Json(cust);
            }
            else
            {
                return Json(new { msg = "Customer with specified id not found" });
            }
        }
    }
}
