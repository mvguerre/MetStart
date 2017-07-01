using MetModels.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetModels.Models
{
    public class CostCentre : EntityBase
    {
        [Index(IsUnique = true)]
        public int CostCentreID { get; set; }
        public string Name { get; set; }
        public bool Terminal { get; set; }
    }
}