using MetModels.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetModels.Models.Employees
{
    public class Employee : EntityBase
    {
        [Index(IsUnique = true)]
        public int Rol { get; set; }

        public virtual Person Person { get; set; }

        /// <summary>
        /// define el estado del trabajador (Activo, Inactivo, Finiquitado)
        /// </summary>
        public EmployeeStatus Status { get; set; }

        /// <summary>
        /// Articulo
        /// </summary>

        public Article Article { get; set; }

        /// <summary>
        /// Tipo de contrato
        /// </summary>
        public ContractType ContractType { get; set; }

        /// <summary>
        /// fecha fin de contrato (en el caso de ser contrato a plazo)
        /// </summary>
        public DateTime? EndContractDate { get; set; }

        /// <summary>
        /// Fecha de Contrato
        /// </summary>
        [Column(TypeName = "date"), Required]
        public DateTime ContractDate { get; set; }

        [Required]
        public virtual CostCentre CostCentre { get; set; }
    }


}