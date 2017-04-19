using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomControllerFactory.Controllers
{
    public class Home : Controller
    {
        public Home()
        {
            this.ActionInvoker = ActionInvokerSelector.GetCurrentActinInvoker();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult showcustom()
        {
            return new ViewResult() { View = new CustomView() };
        }
    }
}
