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

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            var employees = db.Employees.ToList();
            return Json(employees);
        }

        [HttpPost]
        public JsonResult UpdateEmployee(EmployeeController employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return Json(employee);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}