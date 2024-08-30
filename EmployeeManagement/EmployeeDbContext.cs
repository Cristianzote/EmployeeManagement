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
        //Añadir aqui la connection string de una base de datos sql, puedes añadirla y nombrarla en Employee.Management.Web.Config <connectionStrings>
        public EmployeeDbContext() : base("SomeeSqlDbConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}