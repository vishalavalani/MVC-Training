using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDbApp.ViewModel
{
    public class EmployeeVM
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int GenderID { get; set; }
        public System.DateTime DateOfJoining { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }


        public string Gender { get; set; }
        public string Department { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


    }
}
