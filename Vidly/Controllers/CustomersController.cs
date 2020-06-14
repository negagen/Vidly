using Vidly.Models;
using Vidly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers = new List<Customer>
            {
                new Customer { ID = 1, Name = "John Smith"},
                new Customer { ID = 2, Name = "Mary Williams"}
            };
        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = customers.Find(x => x.ID == id);
            if (customer != null) { 
                return View(customer);
            }
            return HttpNotFound();
        }
    }
}