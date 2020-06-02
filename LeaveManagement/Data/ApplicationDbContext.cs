using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Data
{
    // DbContext is used for code first database migrations - create classes that model what tables look like
    // Migrations create the tables for us based on the classes
    public class ApplicationDbContext : IdentityDbContext
    {
        // constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        // When constructing the database - also need these tables 
        public DbSet<Employee> Employees { get; set; } // Extending 1 table - ASpNetUsers
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

    }
}
