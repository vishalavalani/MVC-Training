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

        public ActionResult GetEmployees()
        {
            EmployeeMain main = new EmployeeMain();
            main.EmployeeList = new List<Employee>();

            main.PageNumber = 1;
            main.TotalNumberOfItemsPerPage = 2;

            List<Employee> employeeList = new List<Employee>();

            Employee employee = new Employee();
            employee.EmployeeID = 1001;
            employee.FirstName = "Vishal";
            employee.LastName = "Avalani";
            employee.Salary = 1000;

            Employee employee1 = new Employee();
            employee1.EmployeeID = 1002;
            employee1.FirstName = "Rudy";
            employee1.LastName = "Meri";
            employee1.Salary = 2200;

            Employee employee2 = new Employee();
            employee2.EmployeeID = 1002;
            employee2.FirstName = "Manan";
            employee2.LastName = "Brahma";
            employee2.Salary = 1500;

            employeeList.Add(employee);
            employeeList.Add(employee1);
            employeeList.Add(employee2);

            main.TotalItems = employeeList.Count;
            main.EmployeeList = employeeList.Skip(main.PageNumber -1).Take(main.TotalNumberOfItemsPerPage).ToList();
            return View(main);
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee e)
        {
            //We want to save data in database
            try
            {
                //try to save data in db
                ViewBag.ErrorMessage = "";
                throw new Exception("This is a custom exception for demo");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                //try to print exception
                return View();
            }
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