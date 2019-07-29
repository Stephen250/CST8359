using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST8359_Lab9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OneBottles() 
        {
            return View();        
        }
        public ActionResult FiveBottles() 
        {
            return View();
        }
        public ActionResult SevenBottles() 
        {
            return View();
        }

    }
}