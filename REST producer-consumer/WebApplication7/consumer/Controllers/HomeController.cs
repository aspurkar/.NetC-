﻿using consumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace consumer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();      
    }
        public ActionResult Consume(data d) {

            return View("Result");
        }

      
    }
}