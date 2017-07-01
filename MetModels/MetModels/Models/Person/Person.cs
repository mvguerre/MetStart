using MetModels.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetModels.Models
{
    public class Person : EntityBase
    {
        //PK
        [Index(IsUnique = true)]
        public int RUT { get; set; }

        /// <summary>
        /// Digito verificador
        /// </summary>
        [StringLength(1), Required]
        public string DV { get; set; }

        /// <summary>
        /// Nombre
        /// </summary>
        [StringLength(50), Required]
        public string Names { get; set; }

        /// <summary>
        /// Apellido Paterno
        /// </summary>
        [StringLength(20), Required]
        public string LastName { get; set; }

        /// <summary>
        /// Apellido Materno
        /// </summary>
        [StringLength(20), Required]
        public string SecondLastName { get; set; }

        /// <summary>
        /// Sexo
        /// </summary>
        public string Gender { get; set; }
    }
}