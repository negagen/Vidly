using Vidly.Models;
using Vidly.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
  
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.ID == id);
            if (customer != null)
                return View(customer);
            
            return HttpNotFound();
        }
    }
}