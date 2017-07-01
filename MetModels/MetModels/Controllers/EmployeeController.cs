using MetModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MetModels.Controllers
{
    public class EmployeeController : ApiController
    {
        private EntityModel db = new EntityModel();

        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            //TODO: extend DTO
            var emp = from e in db.Employees
                       select new Views.EmployeeDTO
                       {
                           Name = e.Person.Names,
                           Rut = e.Person.RUT.ToString()
                       };
            return Ok(emp.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
