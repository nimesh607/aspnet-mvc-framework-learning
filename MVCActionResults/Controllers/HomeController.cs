using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionResults.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Register()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        public ViewResult ForgotPassword()
        {
            return View("ForgotPwd");//Action method name is different from View name so we need to specify the View name
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult ResetPassword()
        {
            return View("~/Views/Home/ResetPwd.cshtml");
        }

        public ViewResult Mission()
        {
            return View("~/Views/Test/Mission.cshtml");//we need to give path because it is not either in home or shared folder  .
        }
    }
}