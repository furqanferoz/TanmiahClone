using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TanmiahClone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
              name: "breadcrum",
              url: "BreadCrumController/BreadCrumAction",
              defaults: new { controller = "BreadCrumController", action = "BreadCrumAction" }
          );
        }
        public static void RegisterViewEngins(ICollection<IViewEngine> engines)
        {
            engines.Clear();
            engines.Add(new RazorViewEngine()
            {

                PartialViewLocationFormats = new[] { "~/Views/PartialView/{0}.cshtml" }

            });
        }
    }
}
