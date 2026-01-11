using MVCUIDesigning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View( );
        }


        /*  [HttpPost]
         * public ViewResult AddEmp(int? id, string name, string job, double? salary)
         {
             ViewData["Id"] = id;
             ViewData["Name"] = name;
             ViewData["Job"] = job;
             ViewData["Salary"] = salary;
             return View("DisplayEmp1");
         }*/

        //Here we used FormCollection to collect the form data from the view.instead of using each parameters.Suppose if there are more number of fields in the form then it is better to use FormCollection to collect all the form data.
      /*  [HttpPost]
        public ViewResult AddEmp(FormCollection fc)
        {
            ViewData["Id"] = fc["id"];
            ViewData["Name"] = fc["name"];
            ViewData["Job"] = fc.Get("Job");
            ViewData["Salary"] = fc["Salary"];
            return View("DisplayEmp1");
        }*/

        //Here we used Model Binding to collect the form data from the view.instead of using each parameters.Suppose if there are more number of fields in the form then it is better to use Model Binding to collect all the form data.than in view use Model.fieldname to access the field value.

        [HttpPost]
        public ViewResult AddEmp(Employee emp)
        {
            
            return View("DisplayEmp2",emp);
        }


        //HTML Helpers are used to create the HTML controls by calling the helper methods in the view.Eg: TextBox, DropDownList, RadioButton, CheckBox, etc.
        /* Syntax: @Html.TextBox(string name) => MvcHtmlString(Return Type)
         Example: @Html.TextBox("Id") => <input type = "text" id="Id" name="Id" value="" />*/
    }
}