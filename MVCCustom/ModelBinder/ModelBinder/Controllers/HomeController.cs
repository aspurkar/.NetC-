using ModelBinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinder.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDomains(IEnumerable<System.Net.IPAddress> ipAddress)
        {
            return View("showips", ipAddress);
        }
    }
}
