using FirstDbApp.Data;
using FirstDbApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FirstDbApp.Controllers
{
    public class EmployeesController : Controller
    {
        private EMSTrainingEntities db = new EMSTrainingEntities();

        // GET: Employees
        public ActionResult Index()
        {
            List<EmployeeVM> EList = (from a in db.Employees
                                      select new EmployeeVM()
                                      {
                                          EmployeeID = a.EmployeeID,
                                          FirstName = a.FirstName,
                                          LastName = a.LastName,
                                          Email = a.Email,
                                          Address = a.Address,
                                          ContactNumber = a.ContactNumber,
                                          DateOfBirth = a.DateOfBirth,
                                          DateOfJoining = a.DateOfJoining,
                                          IsActive = a.IsActive,
                                          DepartmentID = a.DepartmentID,
                                          GenderID = a.GenderID,
                                          CreatedDate = a.CreatedDate,
                                          CreatedBy = a.CreatedBy,
                                          ModifiedDate = a.ModifiedDate,
                                          ModifiedBy = a.ModifiedBy,
                                          Gender = a.Gender.Name,
                                          Department = a.Department.Name,
                                      }).ToList();
            return View(EList);
        }


        public ActionResult Create()
        {
            ViewBag.GenderID = new SelectList(db.Genders, "GenderID", "Name");
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeVM employee)
        {
            Employee empdb = (Employee)employee;
            empdb.CreatedBy = "1";
            empdb.ModifiedBy = "1";
            empdb.CreatedDate = DateTime.Now;
            empdb.ModifiedDate = DateTime.Now;

            db.Employees.Add(empdb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            EmployeeVM employee = (from a in db.Employees.Where(d => d.EmployeeID == id)
                                   select new EmployeeVM()
                                   {
                                       EmployeeID = a.EmployeeID,
                                       FirstName = a.FirstName,
                                       LastName = a.LastName,
                                       Email = a.Email,
                                       Address = a.Address,
                                       ContactNumber = a.ContactNumber,
                                       DateOfBirth = a.DateOfBirth,
                                       DateOfJoining = a.DateOfJoining,
                                       IsActive = a.IsActive,
                                       DepartmentID = a.DepartmentID,
                                       GenderID = a.GenderID,
                                       CreatedDate = a.CreatedDate,
                                       CreatedBy = a.CreatedBy,
                                       ModifiedDate = a.ModifiedDate,
                                       ModifiedBy = a.ModifiedBy,
                                   }).FirstOrDefault();

            if(employee == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ViewBag.GenderID = new SelectList(db.Genders, "GenderID", "Name");
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Name");

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeVM employee)
        {
            Employee empdb = (Employee)employee;
            empdb.ModifiedDate = DateTime.Now;
            empdb.ModifiedBy = "1";
            db.Entry(empdb).State = EntityState.Modified;
            db.SaveChanges();

            ViewBag.GenderID = new SelectList(db.Genders, "GenderID", "Name");
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Name");

            return RedirectToAction("Index");
        }

    }
}
