﻿using E_banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_banking.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public E_BankingEntities db = new E_BankingEntities();
        private List<feedback> Feedbacks = new List<feedback>();
        Customer customer = new Customer();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return View();
        }

        public ActionResult ViewFeedback()
        {
            Feedbacks = db.feedbacks.ToList();
            return View(Feedbacks);
        }
        [HttpGet]
        public ActionResult ViewDetails()
        {         
            return View();
        }

        [HttpPost]
        public ActionResult ViewDetails(string id)
        {
            int newId = int.Parse(id);
            customer = db.Customers.Where(a => a.acc_Number == newId).FirstOrDefault();
            return View(customer);
        }
        

    }
}