using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["EMSTitle"] = "Employee Management System View Data";
            ViewBag.HomeTitle = "Employee Management System";
            return View();
        }

        public ActionResult HelloRudy()
        {
            return View();
        }

        public ActionResult GetEmployee()
        {
            Employee employee = new Employee();
            employee.EmployeeID = 1001;
            employee.FirstName = "Vishal";
            employee.LastName = "Avalani";
            employee.Salary = 1000;

            ViewBag.FirstName = employee.FirstName;
            ViewBag.LastName = employee.LastName;
            ViewBag.Salary = employee.Salary;
            return View();
        }

        public ActionResult GetStrongEmployee()
        {
            Employee employee = new Employee();
            employee.EmployeeID = 1001;
            employee.FirstName = "Vishal";
            employee.LastName = "Avalani";
            employee.Salary = 1000;
            return View(employee);
        }

        public ActionResult GetStrongStudent()
        {
            Student s = new Student();
            s.StudentID = 1001;
            return View(s);
        }




        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}