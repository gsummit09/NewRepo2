using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_feb01_MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.msg = "Customer List";
            List<String> list = new List<String>()
            {
                "Itishree",
                "Sumit",
                "priyanka",
                "Biswa"
            };
            ViewBag.nameList=list;
            return View();
        }
        [HttpGet]
        public ActionResult RedirectDemo()
        {
            TempData["WelcomeMessage"] = "WelCome to our Application";
            return RedirectToAction("Index");
        }
        
    }
}