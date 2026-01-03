using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        /*
         * this is a Property defined under the class “ControllerBase” which is a grandparent for all our Controllers, so we can directly consume “ViewData” property in our Controller classes. ViewData is of type “ViewDataDictionary” which will internally store the data in the form of “Key - Value” or “Name - Value” combination, so values that are stored in this “ViewData” will internally be stored in “ViewDataDictionary”.
         * 
         * Syntax: ViewData[string Key] = Value (object)
            Example: ViewData["Name"] = "Raju";
        */
        public ViewResult Index1(int? id, string name, double? price)
        {
            ViewData["Id"] = id;
            ViewData["Name"] = name;
            ViewData["Price"] = price;
            return View();
        }

        public ViewResult Display1()
        {
            List<string> Colors = new List<string>() { "Red", "Blue", "Pink", "Black", "White", "Green", "Brown", "Purple" };
            ViewData["Colors"] = Colors;
            return View();
        }

        /*
         * ViewBag is a dynamic property that takes advantage of the new dynamic features in C# 4.0. ViewBag is actually a wrapper around ViewData, which means that when you set a value in ViewBag, it is actually being stored in ViewData.
         * 
         * Syntax: ViewBag.PropertyName = Value (object)
            Example: ViewBag.Name = "Raju";
        */
        public ViewResult Index2(int? id, string name, double? price)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Price = price;
            return View();
        }

        /*
         *
         *this is also a property under the class “ControllerBase”, but this is of type “TempDataDictionary”. Both
        “ViewDataDictionary” and “TempDataDictionary” are child classes of “IDictionary” interface which is designed
        for storing data in [key-value] or [name-value] combination.
        The only difference between TempData and ViewData is TempData can maintain the state of values between multiple
        requests i.e., it can pass values from 1 action method to another action method which are present in the same
        controller or another controller also.
        */
        //http://localhost:port/Home/Index3/105/Shoes/3500
        public RedirectToRouteResult Index3(int? id, string name, double? price)
        {
            ViewData["Id"] = id;
            ViewBag.Name = name;
            TempData["Price"] = price;
            return RedirectToAction("Index4");
        }
        public ViewResult Index4()
        {
            return View();
        }

        //http://localhost:port/Home/Index5/105/Shoes/3500(Notice the URL redirect in url bar)
        public RedirectToRouteResult Index5(int? id, string name, double? price)
        {
            TempData["Id"] = id;
            TempData["Name"] = name;
            TempData["Price"] = price;
            return RedirectToAction("Index1", "Test");
        }

        public ViewResult Index6(int? Id, string Name, double? Price)
        {
            HttpCookie cookie = new HttpCookie("ProductCookie");
            cookie["Id"] = Id.ToString();
            cookie["Name"] = Name;
            cookie["Price"] = Price.ToString();
            cookie.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(cookie);
            return View();
        }
        public ViewResult Index7()
        {
            return View();
        }

        public RedirectToRouteResult Index8(int? id, string name, double? price)
        {
            Session["Id"] = id;
            Session["Name"] = name;
            Session["Price"] = price;
            return RedirectToAction("Index9");
        }
        public ViewResult Index9()
        {
            return View();
        }

        public RedirectToRouteResult Index10(int? id, string name, double? price)
        {
            Session["Id"] = id;
            Session["Name"] = name;
            Session["Price"] = price;
            return RedirectToAction("Index3", "Test");
        }

    }
}