using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MetModels.Models.Employees
{
    public enum EmployeeStatus
    {
        [Description("Finiquitado")]
        Fired,
        [Description("Activo")]
        Active,
        [Description("Inactivo")]
        Inactive
    }
}