using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUIDesigning.Models
{
    public class Employee
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double? Salary { get; set; }
    }
}