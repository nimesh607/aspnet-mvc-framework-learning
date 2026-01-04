using MVCDataTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index1()
        {
            return View();
        }
        public ViewResult Display1()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            return View();
        }
        public ViewResult Display2()
        {
            return View();
        }

        public ViewResult Index4(Product product)
        {
            return View(product);
        }
    }
}