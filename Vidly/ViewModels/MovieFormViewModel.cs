using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? ID { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genero")]
        public byte? GenreID { get; set; }

        [Display(Name = "Fecha de estreno")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20)]
        [Display(Name = "Cantidad disponible en el almacen")]
        [Required]
        public int? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return ID != 0 ? "Editar pelicula" : "Añadir pelicula";
            }
        }

        public MovieFormViewModel()
        {
            ID = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            ID = movie.ID;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreID = movie.GenreID;
        }
    }
}