using PartialViewChildActions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewChildActions.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [ChildActionOnly]
        public ActionResult show()
        {
            var stud = new Student();
            stud.Name = "Aditya";
            stud.Email = "adi@yahoo.com";
            stud.Mpbile = "76574564654";
            stud.StudentId = 1001;
            stud.Address = new Address();
            stud.Address.City = "San Fran";
            stud.Address.Country = "United States";
            stud.Address.State = "California";
            return View(stud);
        }
        public ActionResult show2()
        {
            return View();
        }
    }
}
