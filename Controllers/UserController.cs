using E_banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_banking.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult NewTransaction()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewTransaction(bill bill)
        {
            return View();

        }


        
        public ActionResult TransferMoney()
        {
            return View();

        }

        public ActionResult ViewBalance()
        {
            return View();

        }

        public ActionResult ViewTransaction()
        {
            return View();

        }

    }
}