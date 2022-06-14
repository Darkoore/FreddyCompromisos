using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Compromisos.Models
{
    public class IdFuncionario
    {
        [Required(ErrorMessage = "Please enter Your Username !")]
        [Display(Name = "Ingrese su Func_id")]
        public string FUNC_ID { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese su password !")]
        [Display(Name = "Ingrese su Utrabajo")]
        [DataType(DataType.Password)]
        public string FUNC_UTRABAJO { get; set; }

    }
}