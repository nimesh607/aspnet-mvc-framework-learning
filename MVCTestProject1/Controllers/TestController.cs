using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject1.Controllers
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "Hello from Test Controller - Index Action Method.";
        }
        public string Show()
        {
            return "Hello from Test Controller - Show Action Method.";
        }
    }
}