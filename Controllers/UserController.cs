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
        public E_BankingEntities db = new E_BankingEntities();
        Customer customer = new Customer();
        static int userId;
        private List<Transcation> transcations = new List<Transcation>();
        private List<bill> bills = new List<bill>();
         
        // GET: User
        public ActionResult Index(int id)
        {
            userId = id;
            return View();
        }

        [HttpGet]
        public ActionResult NewTransaction()
        {
          
            ViewBag.id = userId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewTransaction(bill bill)
        {
            ViewBag.id = userId;
            Customer cust = new Customer();
            cust = db.Customers.Where(a => a.acc_Number == userId).FirstOrDefault();
            if (cust.balance >= bill.amount && bill.amount>0)
            {
                ViewBag.success = "transaction done successfully";
                bill.user_id = userId;
                UpdatingOnBalance(bill.amount);
                db.bills.Add(bill);
                db.SaveChanges();
                return View();
            }
            else
            {
                if(bill.amount > 0)
                {
                    ViewBag.Error = "Your Balance Is Not Enough";
                }          
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddFeedback()
        {
            ViewBag.id = userId;
            return View();
        }
        [HttpPost]
        public ActionResult AddFeedback(feedback msg)
        {
            if(msg.message != null)
            {
                ViewBag.success = "feedback sent successfully";
                ViewBag.id = userId;
                msg.user_id = userId;
                db.feedbacks.Add(msg);
                db.SaveChanges();
            }  
            else
            {
                ViewBag.Error = "you have to enter feedback";
            }
            return View();
        }

        [HttpGet]
        public ActionResult TransferMoney()
        {
            ViewBag.senderId = userId;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TransferMoney(Transcation transcation)
        {
            ViewBag.senderId = userId;
            Customer cust = new Customer();
            cust = db.Customers.Where(a => a.acc_Number == userId).FirstOrDefault();
            if (cust.balance >= transcation.amount && transcation.amount > 0)
            {
                ViewBag.success = "transaction done successfully";
                transcation.sender_id = userId;
                UpdatingOnBalance(transcation.amount);
                UpdatingBalance(transcation.amount, transcation.receiver_id);
                db.Transcations.Add(transcation);
                db.SaveChanges();
                return View();
            }
            else
            {
                if(transcation.amount > 0)
                {
                    ViewBag.Error = "Your Balance Is Not Enough";
                }              
                return View();
            }
        }



        public ActionResult ViewTransaction()
        {
            transcations = db.Transcations.Where(a => a.sender_id == userId).ToList();
            bills = db.bills.Where(a => a.user_id == userId).ToList();
            ViewBag.bills = bills;
            ViewBag.id = userId;
            return View(transcations);

        }
    
        public ActionResult ViewBalance()
        {
            customer = db.Customers.Where(a => a.acc_Number == userId).FirstOrDefault();
            return View(customer);
        }

        public void UpdatingOnBalance(double balance)
        {
            Customer cust = new Customer();
            cust = db.Customers.Where(a => a.acc_Number == userId).FirstOrDefault();
            cust.balance -= balance;
            db.SaveChanges();

        }
        public void UpdatingBalance(double balance,int recId)
        {
            Customer cust = new Customer();
            cust = db.Customers.Where(a => a.acc_Number == recId).FirstOrDefault();
            cust.balance += balance;
            db.SaveChanges();

        }
    }
}