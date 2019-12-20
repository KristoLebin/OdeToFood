using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();
        public ActionResult Index(string searchTerm=null)
        {
            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var id = RouteData.Values["id"];
            //ViewBag.message = $"{controller} :: {action} - {id}";

            //var model =
            //    from r in _db.Restaurants
            //    orderby r.Reviews.Average(review => review.rating)
            //    select new RestaurantListViewModel
            //    {
            //        Id = r.Id,
            //        Name = r.Name,
            //        City = r.City,
            //        Country = r.Country,
            //        CountOfReviews = r.Reviews.Count()
            //    };
            var model =
                _db.Restaurants
                    .OrderByDescending(r => r.Reviews.Average(review => review.rating))
                    .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                    .Take(10)
                    .Select(r => new RestaurantListViewModel
                        {
                            Id = r.Id,
                            Name = r.Name,
                            City = r.City,
                            Country = r.Country,
                            CountOfReviews = r.Reviews.Count()
                        });
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
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
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}