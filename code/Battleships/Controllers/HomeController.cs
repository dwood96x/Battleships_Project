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
        public ActionResult Register([Bind(Include = "username,password,email")] Users register)
        {
            if (ModelState.IsValid)
            {
                using (EFDbContext context = new EFDbContext())
                {
                    context.Users.Add(register);
                    context.SaveChanges();
                    return View("Index");
                }
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