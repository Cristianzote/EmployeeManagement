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
        public EmployeeDbContext() : base("workstation id = CrissCrossDB.mssql.somee.com; packet size = 4096; user id = cristiancitoowo_SQLLogin_1; pwd=2z4ye55q3e;data source = CrissCrossDB.mssql.somee.com; persist security info=False;initial catalog = CrissCrossDB; TrustServerCertificate=True")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}