using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MetModels.Models.Employees
{
    public enum ContractType
    {
        [Description("Fijo")]
        Fijo,
        [Description("Indefinido")]
        Indefinido
    }
}