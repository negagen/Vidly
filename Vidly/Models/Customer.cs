using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el nombre del cliente.")]
        [StringLength(255)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name =  "Tipo de membresia")]
        public byte MembershipTypeID { get; set; }
    }
}