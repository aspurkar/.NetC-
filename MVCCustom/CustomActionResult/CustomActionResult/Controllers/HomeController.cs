using CustomActionResult.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomActionResult.Controllers
{
    public class MyControllerBase : Controller
    {
        public ActionResult Xml(object obj)
        {
            return new XmlResult(obj);
        }
    }
    public class HomeController : MyControllerBase
    {

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStudent()
        {
            var stud = new Student();
            stud.StudentId = 1001;
            stud.Email = "aditya@yahoo.com";
            stud.Mobile = "9844343244";
            stud.Name = "Aditya";
           // return new JsonResult() { Data = stud,JsonRequestBehavior= JsonRequestBehavior.AllowGet };
           // return Json(stud, JsonRequestBehavior.AllowGet);
            return Xml(stud);
        }
        public ActionResult image(int id)
        {
            var bytes=  System.IO.File.ReadAllBytes(@"C:\temp\Tulips.jpg");
            return File(bytes,"image/png");
        }

    }
}
