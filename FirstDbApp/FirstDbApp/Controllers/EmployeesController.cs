using FirstDbApp.Data;
using FirstDbApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
