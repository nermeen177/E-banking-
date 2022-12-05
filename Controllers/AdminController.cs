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
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}