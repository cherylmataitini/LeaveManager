using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class DetailsLeaveTypeViewModel // this is an abstraction over the original LeaveType Model class (that models a table - it is in the Data folder)
    {
        // these are the same properties in the LeaveType model class
        // but you may have more/fewer properties that are inside a ViewModel - different to the Model class
      
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        [Display(Name="Date Created")]
        public DateTime DateCreated { get; set; }

    }

    // this is another viewmodel - but we will use this in a view where we create a LeaveType
    public class CreateLeaveTypeViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
