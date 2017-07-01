using MSViews.Models;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSViews.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> GetEmployeeData()
        {
            string res = API.PerformGETRequest(API.GetBaseUrl() + "api/employee/GetAllEmployees");
            return (List<Employee>)JsonConvert.DeserializeObject(res, typeof(List<Employee>));
        }

    }
}
