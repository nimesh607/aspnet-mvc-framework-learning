using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTestProject1
{
    public class RouteConfig
    {
        //Demo of Ruuting by having different url muttplt routes

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name:"Student1",
                url:"IT/NewBatches",
                defaults: new {controller = "Student",action="List"}
                );

            routes.MapRoute(
            name: "Student",
            url: "IT/Students",
            defaults: new { controller = "Student", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{name}",
                defaults:
                new { 
                    controller = "Home", 
                    action = "Index", 
                    id = UrlParameter.Optional,
                    name = UrlParameter.Optional
                }
            );
        }
    }
}
