using HRMAttendance.AggregateRoot.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMAttendance.Repository.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<ManageAttendance> ManageAttendances { get; set; }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Holiday>Holidays { get; set; }
    }
}
