using MSViews.Models;
using MSViews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSViews.Controllers
{
    public class EmployeeController : Controller
    {

        // GET: Employee
        public ActionResult Index()
        {

            var employees = EmployeeRepository.GetEmployeeData();

            return View(employees);
        }

        //GET
        public ActionResult Create()
        {
            //mock up. todo create and call the WS to get all cost centres
            var c = new CostCentre();
            c.CostCentreId = "101";
            c.Name = "Centro1";
            ViewBag.costcentre = new List<CostCentre>() { c };
             
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Name,LastName, SecondLastName, Rut, CostCentre")] Employee employee)
        {
            bool save = true;
            //todo call WS to create new employee
            if (save)
            {
                return RedirectToAction("Index");
            }
            else
                return View();
        }
    }
}