using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Licencia de conducir")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
    }
}