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
    }
}