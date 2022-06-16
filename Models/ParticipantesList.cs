using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Compromisos.Models
{
    public class ParticipantesList
    {
        [Display(Name = "PART_RUT")]
        public string PART_RUT { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string PART_NOMBRE { get; set; }
        [Required(ErrorMessage = "Fono is required.")]
        public string PART_FONO { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string PART_EMAIL { get; set; }
        [Required(ErrorMessage = "Institucion is required.")]
        public string PART_INSTITUCION { get; set; }
    }
}