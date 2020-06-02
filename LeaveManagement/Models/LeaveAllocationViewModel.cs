using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// We don't want to be referencing data classes from a ViewModel - e.g. shouldn't do 'using LeaveManagement.Data' to get access to the Employee and LeaveType classes
// ViewModels should interact with ViewModels
// Data classes should interact with data classes
// - Which is why we created the EmployeeViewModel to use instead of the Employee itself
// - as well as the DetailsLeaceTypeViewModel - to use instead of LeaveType itself


namespace LeaveManagement.Models
{
    public class LeaveAllocationViewModel
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }

        // reference to employee
        public EmployeeViewModel Employee { get; set; }

        // reference to type of leave
        public string EmployeeId { get; set; } // bc Id of AspNetUsers is of type nvarchar (string)

        public DetailsLeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        // represents dropdown list of employees in the database
        public IEnumerable<SelectListItem> Employees { get; set; }
        // represents dropdown list of leavetypes
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

    }
}
