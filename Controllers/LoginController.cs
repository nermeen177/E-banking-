using E_banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_banking.Controllers
{
    public class LoginController : Controller
    {
        public E_BankingEntities db = new E_BankingEntities();
        private List<Customer> customer = new List<Customer>();
        private List<Admin> admin = new List<Admin>();

  
        [HttpGet]
        public ActionResult Index()
        {
            
           return View();
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Person person)
        {
            customer = db.Customers.Where(a => a.username.Equals(person.username) && a.password.Equals(person.password)).ToList();
            admin = db.Admins.Where(a => a.username.Equals(person.username) && a.password.Equals(person.password)).ToList();

            if (customer.Count == 0 && admin.Count == 1)
            {
                return RedirectToAction("Index","Admin", new { id=admin[0].id });
            }
            else if (customer.Count == 1 && admin.Count == 0)
            {
                return RedirectToAction("Index", "User", new { id = customer[0] });
            }
            else
                return View();

        }
        

    }
}