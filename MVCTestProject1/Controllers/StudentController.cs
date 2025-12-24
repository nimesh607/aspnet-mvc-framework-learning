using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTestProject1.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Hello from Student Controller - Index Action method.";
        }

        public string List()
        {
            return "This is new Batch";
        }
    }
}