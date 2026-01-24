using MVCUIDesigning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ViewResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddStudent(Student student)
        {
            return View("DisplayStudent", student);
        }

        [HttpGet]
        public ViewResult AddStudentST()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddStudentST(Student student)
        {
            return View("DisplayStudentST", student);
        }

        /*
         * A Partial View is also a View, but this can be used in other Views, i.e., they provide re-usability. Creating a Partial View is also just like creating a normal View and the extension of the Partial View also will be “.cshtml” only, but in a Partial View we don’t have any HTML tag’s like “<head>” and “<body>” by default. Partial Views are generally stored in the “Shared” folder of “Views” folder because they are consumed by multiple Views in the application, and it is suggested (optional) to prefix Partial View names with “underscore (_)” to differentiate them from other Views.
         * Consume Partial View in a View:
         * @Html.Partial(string PartialViewName) => MvcHtmlString
           @{ Html.RenderPartial(string PartialViewName); } => void
           @{ Html.RenderAction(string ActionMethodName); } => void
         */
        public PartialViewResult Header()
        {
            return PartialView("_Header");
        }
    }
}