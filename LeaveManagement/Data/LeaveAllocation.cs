using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class LeaveAllocation // How many days each emloyee can have for each type of leave
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }

        // reference to employee
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        // reference to type of leave
        public string EmployeeId { get; set; } // bc Id of AspNetUsers is of type nvarchar (string)

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

    }
}
