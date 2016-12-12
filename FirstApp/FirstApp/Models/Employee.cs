using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }

    public class EmployeeMain
    {
        public List<Employee> EmployeeList { get; set; }
        public int PageNumber { get; set; }
        public int TotalNumberOfItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public EmployeeMain()
        {
            EmployeeList = new List<Employee>();
        }
    }
}
