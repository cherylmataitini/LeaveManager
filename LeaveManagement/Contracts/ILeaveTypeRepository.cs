using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType> // implementing this interface - generic T is now concrete class
    {
        // note that this interface implements/ "inherits" all of the members in IRepositoryBase<T> 
        // this way - if there is a specific member that only one implementing class needs to implement - e.g. if only LeaveTypeRepository needs to implement a specific function - then it can be specified here - it doesn't have to be in the IRepositoryBase interface

        ICollection<LeaveType> GetEmployeesByLeaveType(int id); // takes in id for particular leave type
    }
}
