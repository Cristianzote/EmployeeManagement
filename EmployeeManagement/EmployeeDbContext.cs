using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeeManagement.Models;

namespace EmployeeManagement
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeDbContext() : base("SomeeSqlDbConnection")
        {
        }
    }
}