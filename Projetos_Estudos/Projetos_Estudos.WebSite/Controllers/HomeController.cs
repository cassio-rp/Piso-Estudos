﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projetos_Estudos.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sistema de Estudos 2017";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Meu contato";

            return View();
        }
    }
}