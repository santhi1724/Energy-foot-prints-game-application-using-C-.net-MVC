﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game_Web_App.Controllers
{
    public class HomeController : Controller
    {
        GameDBEntities2 db = new GameDBEntities2();
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}