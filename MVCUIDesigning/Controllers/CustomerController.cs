using MVCUIDesigning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class CustomerController : Controller
    {
        Customer c1 = new Customer
        {
            Custid = 1001,
            Name = "Peter",
            Account = "Savings",
            Balance = 50000.00,
            City = "Delhi",
            Status = true,

        };
        Customer c2 = new Customer
        {
            Custid = 1002,
            Name = "Kevin",
            Account = "Current",
            Balance = 50000.00,
            City = "Kolkata",
            Status = true,

        };
        Customer c3 = new Customer
        {
            Custid = 1003,
            Name = "Sandra",
            Account = "Demat",
            Balance = 50000.00,
            City = "Mumabi",
            Status = true,

        };
        Customer c4 = new Customer
        {
            Custid = 1004,
            Name = "Williams",
            Account = "Savings",
            Balance = 50000.00,
            City = "Chennai",
            Status = true,

        };
        Customer c5 = new Customer
        {
            Custid = 1005,
            Name = "John",
            Account = "Demat",
            Balance = 50000.00,
            City = "Bengaluru",
            Status = true,

        };
        Customer c6 = new Customer
        {
            Custid = 1006,
            Name = "Bill",
            Account = "Current",
            Balance = 50000.00,
            City = "Hyderabad",
            Status = true,

        };

        public ViewResult DisplayCustomers()
       {
            //this is without partial view           
            List<Customer> customers = new List<Customer> { c1, c2, c3, c4, c5, c6 };
            return View(customers);
        }

        public ViewResult DisplayCustomersusingpartialview()
        {
            //this is with partial view
            List<Customer> customers = new List<Customer> { c1, c2, c3, c4, c5, c6 };
            return View(customers);
        }


    }
}