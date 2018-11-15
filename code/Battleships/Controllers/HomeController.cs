using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Battleships.Domain.Entities;
using Battleships.Domain.Concrete;
using System.Data.Entity;

namespace Battleships.Controllers
{
    public class HomeController : Controller
    {
        private EFDbContext context = new EFDbContext();

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
            using (var context = new EFDbContext())
            {

            }
            return View(login);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "userName,username,password,email")] Users register)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(register);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
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