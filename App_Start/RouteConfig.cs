using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DataDrunk
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");

            routes.MapRoute(
              name: "Downloads",
              url: "Base/Downloads/{direct}",
              defaults: new { controller = "Base", action = "Downloads", direct = "" }
                );

            routes.MapRoute(
                //routes to app controller instead of home controller
              name: "Apps",
              url: "Apps/{style}",
              defaults: new { controller = "Apps", action = "Index", style = "glitter" }
                );

           routes.MapRoute(
           name: "json",
           url: "json",
            defaults: new { controller = "Base", action = "json", style = "glitter" }
                );

            routes.MapRoute(
             name: "Contact",
             url: "Contact",
            defaults: new { controller = "Contact", action = "Create", style = "glitter" }
                );

            routes.MapRoute(
                name: "About",
                url: "About/{style}",
                defaults: new { controller = "Base", action = "About", style = "glitter" }
                );
           
            routes.MapRoute(
                name: "Home",
                url: "Home/{style}",
               defaults: new { controller = "Base", action = "Index", style = "glitter" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Base", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
