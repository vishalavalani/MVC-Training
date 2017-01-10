using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDbApp.ViewModel
{
    public class EmployeeVM
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot be greater than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot be greater than 50 characters")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Address is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "PhoneNumber is required")]
        public string ContactNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: MM/dd/yyyy}")]
        [Required(ErrorMessage = "Date Of Birth is required")]
        public System.DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        public int GenderID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: MM/dd/yyyy}")]
        [Required(ErrorMessage = "Date Of Joining is required")]
        public System.DateTime DateOfJoining { get; set; }

        [Required(ErrorMessage = "IsActive is required")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Please select Department")]
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
