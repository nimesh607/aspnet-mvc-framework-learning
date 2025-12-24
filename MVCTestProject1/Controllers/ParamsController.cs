using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject1.Controllers
{
    public class ParamsController : Controller
    { /*
         * Passing parameters to Controller’s Action methods: we can define parameters to Action methods, and values to those parameters can be sent in different ways like Route Parameters, Query Strings and Input Controls.
         */

        //Passing value to id is mandatory
        public string Index1(int id)
        {
            return "The value of id is: " + id;
        }
        //Passing value to id is optional and if not passed value will be "0"
        public string Index2(int id = 0)
        {
            return "The value of id is: " + id;
        }
        //Passing value to id is optional and if not passed value will be "null"
        public string Index3(int? id)
        {
            return "The value of id is: " + id;
        }

        /*
         * Note: the parameter name in all the 3 Index action methods should be “id” only (not case sensitive and can be of any type) because it is the same name we have in “RouteConfig.cs” file, so we can’t change it in our action methods and if we try to use a different name to the parameter other than “id” then the value we passed thru the route will not be taken by the action method and to test that define 2 new action methods in the “ParamsController” class as below:
        */

        //Passing value to x is mandatory and if passed also it will not take it because of parameter name mis-match
        public string Index4(int x)
        {
            return "The value of id is: " + x;
        }

        //Passing value to x is optional and if passed also it will not take it because of parameter name mis-match
        public string Index5(int? x)
        {
            return "The value of id is: " + x;
        }

        /*
         * http://localhost:port/Params/Index4 //Invalid because there is no value for  x
           http://localhost:port/Params/Index4/400 //Invalid because the value is not taken to x
           http://localhost:port/Params/Index5 //Valid and the value for x is null
           http://localhost:port/Params/Index5/500 //Valid, but now also the value for x is null only
         */

        /*
         * The name “Id” which is defined in “RouteConfig” under the default route is not specified to be of a particular type so while using it in our action method we can specify any type to it and to test that define a new action method in the “ParamsController” class as following:
         */

        //Passing value to Id is option because it is defined as type string & strings are by default Nullable (reference types)
        public string Index6(string Id)
        {
            return "The value of id is: " + Id;
        }
        /*
         * http://localhost:port/Params/Index6 //Valid and the value for Id is null
           http://localhost:port/Params/Index6/HelloMVC //Valid and the value for Id is "HelloMVC"
         */

        //Passing multiple parameters to action method
        /*
         * If we want to pass multiple parameters to Action methods, we can change the default route “URL” in RouteConfig class, for example if we want to have 2 parameters to our action methods re-write the “URL” as following: url: "{controller}/{action}/{id}/{name}"
         */
        //Passing value to Id is mandatory and Name is optional
        public string Index7(int Id, string Name)
        {
            return $"Value of Id is: {Id} and value of Name is: {Name}";
        }
        //Passing values to Id and Name are optional
        public string Index8(int? Id, string Name)
        {
            return $"Value of Id is: {Id} and value of Name is: {Name}";
        }
        /*
         * http://localhost:port/params/Index7 //Invalid because Id is mandatory parameter
           http://localhost:port/params/Index7/700 //Valid, in this case Name will be null value
           http://localhost:port/params/Index7/700/Raju //Valid
           http://localhost:port/Params/Index7/Raju/700 //Invalid because parameter values not in order
           http://localhost:port/Params/Index7?Id=700&Name=Raju //Valid, as we are passing values by specifying names
           http://localhost:port/Params/Index7?Name=Raju&Id=700 //Valid, as we are passing values by specifying names
         */
        //By using Query String to pass values to action method parameters

        //routes are not affected when we use Query String to pass values to action method parameters
        public string Index9(int Pid, string Pname, double Price)
        {
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }
        /*
         * 
             http://localhost:port/Params/Index9/101/Shirt      //Invalid(Route matched but Server Error because parameter names are changed here is Pid and it accepts only id )
            http://localhost:port/Params/Index9/101/Shoes/3500 //Invalid(Route Error)
            http://localhost:port/Params/Index9?Pid=101&Pname=Shoes&Price=3500 //Valid(Because we arepaaing through Query Strings .And not by Route)
            http://localhost:port/Params/Index9?Pname=Shoes&Price=3500&Pid=101 //Valid
            http://localhost:port/Params/Index9?Price=3500&Pid=101&Pname=Shoes //Valid
                 */

        /*
         * Note: Without defining any parameters to the action method also we can read Query String values in our code, to test that add a new Action method into the “ParamsController” class as following:
          */
        public string Index10()
        {
            int Pid = int.Parse(Request.QueryString["Pid"]);//Not able to handl null and will throw exception
            string Pname = Request.QueryString["Pname"];
            double Price = double.Parse(Request.QueryString["Price"]);
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }
        /*
         *  http://localhost:port/Params/Index10 //Invalid
            http://localhost:port/Params/Index10/101/Shoes/3500 //Invalid
            http://localhost:port/Params/Index10?Pid=101&Pname=Shoes&Price=3500 //Valid
            http://localhost:port/Params/Index10?Pname=Shoes&Price=3500&Pid=101 //Valid
            http://localhost:port/Params/Index10?Price=3500&Pid=101&Pname=Shoes //Valid
         */

        /*
         * Note: re-write the above method as below and this will not cause any error when values are not passed because of Convert.ToIn32 and Convert.ToDouble methods which we used in place of int.Parse and double.Parse methods.
         */
        //Can Handle Nulls smoothly
        public string Index11()
        {
            int Pid = Convert.ToInt32(Request.QueryString["Pid"]); ;
            string Pname = Request.QueryString["Pname"]; double Price = Convert.ToDouble(Request.QueryString["Price"]);
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }
        //QueryStrings:You need to read the values which we are passing through querystrings  :
        //1)how many values you're passing you're method should have that many numbers of parameters.
        //2)Using Request object.i.e:Request.QueryString
        //Code:
        public string Validate1()
        {
            string Name = Request.QueryString["Name"];//Reading by Request object
            string Pwd = Request.QueryString["Pwd"];
            if (Name == "Joe" && Pwd == "Admin")
                return "Valid User";
            else
                return "Invalid User";
        }
        public string Validate2(string Name, string Pwd)//Reading by Parameter
        {
            if (Name == "Joe" && Pwd == "Admin")
                return "Valid User";
            else
                return "Invalid User";
        }
    }
}