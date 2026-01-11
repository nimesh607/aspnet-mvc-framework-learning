using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIDesigning
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "LogIn",
            url: "logIn",
            defaults: new { controller = "Account", action = "LogIn", id = UrlParameter.Optional }
            );


            routes.MapRoute(
            name: "Student",
            url: "student",
            defaults: new { controller = "Student", action = "AddStudent", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Emp", action = "AddEmp", id = UrlParameter.Optional }
            );


        }
    }
}
