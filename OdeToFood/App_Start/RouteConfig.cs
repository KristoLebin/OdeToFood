using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Cuisine",
                url: "Cuisine/{name}",
                defaults: new { controller = "cuisine", action = "search", name = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Kristo",
                url: "McDonalds/{location}/{meal}",
                defaults: new { controller = "McDonalds", action = "Kristo", location = UrlParameter.Optional, meal = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
