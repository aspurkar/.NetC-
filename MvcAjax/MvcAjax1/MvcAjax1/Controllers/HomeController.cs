using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAjax1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View("ajax");
        }
        public ActionResult show()
        {
            try
            {
                ViewBag.Key = Request.Headers["appkey"];
                return View();
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(ex.Message,JsonRequestBehavior.AllowGet);
            }
        }
    }
}
