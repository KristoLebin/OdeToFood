﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            ViewBag.message = $"{controller} :: {action} - {id}";
            return View();
        }

        public ActionResult About()
        {
            var Model = new AboutModels();
            Model.Name = "Kristo";
            Model.Location = "Tallinn, Estonia";
            Model.Age = 17;

            return View(Model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}