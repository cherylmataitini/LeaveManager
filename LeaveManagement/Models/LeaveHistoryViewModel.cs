﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveHistoryViewModel
    {
        public int Id { get; set; }
        public EmployeeViewModel RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public DetailsLeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; } // the ? - means can be nullable - so may be true/false/null where null means it would be pending 
        public EmployeeViewModel ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }
}
