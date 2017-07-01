using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MetModels.Models.Employees;

namespace MetModels.Models
{
    public class EntityModel : DbContext
    {
        private static string IPDev = "172.168.200.6";
        private static string ConnectionString
            = "data source=" + IPDev + ";initial catalog=MSRRHH; persist security info=True;user id=test;password=testtest;MultipleActiveResultSets=True;App=RRHH-API-TEST";

        public EntityModel()
            : base(EntityModel.ConnectionString)
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CostCentre> CostCentres { get; set; }
    }
}