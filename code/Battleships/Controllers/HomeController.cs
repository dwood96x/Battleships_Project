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

        public ActionResult About()
        {
            ViewBag.Message = "This is my Battleships description page.";

            return View();
        }

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