using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext db = new EmployeeDbContext();

        //Mostrar vista principal
        public ActionResult Index()
        {
            return View();
        }

        //Traer todos los empleados de la base de datos en un array
        public JsonResult GetEmployees()
        {
            List<Employee> employees = db.Employees.ToList();
            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        //Guardar un empleado nuevo
        [HttpPost]
        public JsonResult AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return Json(employee);
        }

        //Actualizar un empleado
        [HttpPost]
        public JsonResult UpdateEmployee(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return Json(employee);
        }
        //Eliminar un empleado
        [HttpPost]
        public JsonResult DeleteEmployee(int id)
        {
            var employee = db.Employees.Find(id);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
            return Json(employee);
        }
    }
}