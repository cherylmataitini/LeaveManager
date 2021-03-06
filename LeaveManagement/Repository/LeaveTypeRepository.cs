﻿using LeaveManagement.Contracts;
using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagement.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {;
            return _db.LeaveTypes.ToList(); // _db.LeaveTypes will give all of the items in the table - but we want it as a collection which is why we did ToList()
        }

        public LeaveType FindById(int id)
        {
            return _db.LeaveTypes.FirstOrDefault(l => l.Id == id);
            // or return _db.LeaveTypes.Find(id);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0; // boolean - will be greater than 0 if true   
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
