using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class McDonaldsController : Controller
    {
        // GET: McDonalds
        public ActionResult Kristo(string location, string meal)
        {
            return Content($"Location of restaurant: {location} <br/> Meal: {meal}");
        }
    }
}