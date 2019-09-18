using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tracker.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Required(ErrorMessage ="Employee ID is Required")]
        [Key]
        public string EmployeeID { get; set; }

        [Required(ErrorMessage ="Employee Name is Required")]
        public string EmployeeName { get; set; }

        [EmailAddress(ErrorMessage ="Invalid EMail Address")]
        [Required(ErrorMessage ="Email Address is Required")]
        public string Email { get; set; }

        
    }
}
