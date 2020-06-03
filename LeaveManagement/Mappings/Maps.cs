using AutoMapper;
using LeaveManagement.Data;
using LeaveManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Mappings
{
    public class Maps : Profile // from AutoMapper
    {
        public Maps()
        {
            // creating the maps that should exist in our application
            // CreateMap<DataClass,ViewModel> i.e. source and destination

            CreateMap<LeaveHistory, LeaveHistoryViewModel>().ReverseMap(); // ReverseMap() allows you to map data in either direction - getting data from source -> destination & vice versa
            CreateMap<LeaveType, DetailsLeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }

    }
}
