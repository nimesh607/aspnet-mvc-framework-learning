using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult LogIn()
        {
            return View();
        }

        public ViewResult Validate()
        {
            string uname = Request.Form["username"];//Here we are using Request.Form to collect the form data from the view.instead of using parameters.
            string pwd = Request.Form["password"];
            if(uname=="admin" && pwd=="admin123")
            {
                Session["uname"] = uname;
                return View("Sucess");
            }
            else
            {

               ViewBag.uname = uname;
                return View("Failure");
            }
        }
    }
}