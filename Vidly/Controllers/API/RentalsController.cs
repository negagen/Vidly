using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{ 
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
            var customer = _context.Customers.Single(c => c.ID == rentalDto.CustomerId);

            var movies = _context.Movies.Where(
                m => rentalDto.MovieIds.Contains(m.ID)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                var rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                movie.NumberAvailable--;

                _context.Rentals.Add(rental);
            }
            
            _context.SaveChanges();

            return Ok();
        }
    }
}