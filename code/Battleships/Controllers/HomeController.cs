using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Battleships.Domain.Entities;

namespace Battleships.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            return View(login);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register register)
        {
            return View(register);
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