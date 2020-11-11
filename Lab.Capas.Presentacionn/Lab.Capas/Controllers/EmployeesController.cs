using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab.Demo.Entities;
using Lab.Demo.Logic;

namespace Lab.Capas.Controllers
{
    public class EmployeesController : Controller
    {


        // GET: Employees
        public ActionResult Index()
        {
            var logic = new EmployeesLogic();
            var employees = logic.GetAll();
            return View(employees);
        }
        
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
            
        [HttpPost]
        public ActionResult Insert(Employees employee)
        {
            var logic = new EmployeesLogic();
            var employeeEntity = new Employees() { FirstName = employee.FirstName, LastName= employee.LastName};
            logic.Insert(employeeEntity);
            return RedirectToAction("index");
            
        }

        public ActionResult Delete(int id)
        {
            var logic = new EmployeesLogic();
            logic.Delete(id);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeesLogic logic = new EmployeesLogic ();
            Employees employees = logic.GetOne(id);
            return View(employees);
        }

        [HttpPost]
        public ActionResult Edit(Employees employees)
        {
            var logic = new EmployeesLogic();
            logic.Update(employees);
            return RedirectToAction("index");
        }

    }
}
