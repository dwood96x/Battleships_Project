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
        public ActionResult Login(Users login)
        {
            using (EFDbContext context = new EFDbContext())
            {
                try
                {
                    var user = context.Users.Single(u => u.username == login.username && u.password == login.password);
                    if (user != null)
                    {
                        Session["UserID"] = user.userID.ToString();
                        Session["Username"] = user.username.ToString();
                        ViewBag.Result = "You have successfully logged in " + login.username;
                    }
                    else
                    {
                        ModelState.AddModelError("", "Username or password is wrong.");
                    }
                }
                catch (System.InvalidOperationException)
                {
                    ViewBag.Result = "Incorrect username or password, please try again.";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Users register)
        {
            if (ModelState.IsValid)
            {
                using (EFDbContext context = new EFDbContext())
                {
                    context.Users.Add(register);
                    context.SaveChanges();
                    ViewBag.SuccessfulMessage = "You have successfully registered " + register.username;
                    System.Threading.Thread.Sleep(3500);
                    //return View("Index");
                }
            }
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