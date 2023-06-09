﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace blackBox.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 120, Location = OutputCacheLocation.Server, VaryByParam ="*")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            throw new Exception();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}