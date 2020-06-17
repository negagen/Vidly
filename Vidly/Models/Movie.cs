using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }
        
        [Required]
        [Display(Name = "Genero")]
        public byte GenreID { get; set; }

        [Display(Name = "Fecha de estreno")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Fecha en que se añadio a la base de datos")]
        public DateTime DateAdded { get; set; }

        [Range(1,20)]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
        public int NumberAvailable { get; set; }
    }

    // /movies/random
}