using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Battleships.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        // Disabled in _Layout for now
        public ActionResult Contact()
        {
            ViewBag.Message = "My contact info.";
            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }
    }
}