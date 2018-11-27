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
                        ViewBag.GoodResult = "You have successfully logged in " + login.username;
                    }
                }
                catch (System.InvalidOperationException)
                {
                    ViewBag.BadResult = "Incorrect username or password, please try again.";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        // The registration method takes in a User and adds it to the database, assuming there is no conflicts between it and the database.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Users register)
        {
            if (ModelState.IsValid)
            {
                using (EFDbContext context = new EFDbContext())
                {
                    bool duperror = false;
                    if (context.Users.Where(u => u.username == register.username).Count() != 0)
                    {
                        ViewBag.UserExist = "That username is taken";
                        duperror = true;
                    }
                    if (context.Users.Where(u => u.email == register.email).Count() != 0)
                    {
                        ViewBag.EmailExist = "That email is taken";
                        duperror = true;
                    }
                    if (duperror == true)
                    {
                        ViewData["duperror"] = duperror;
                        return View();
                    }
                    context.Users.Add(register);
                    context.SaveChanges();
                    ViewBag.SuccessfulMessage = "You have successfully registered " + register.username;
                    //System.Threading.Thread.Sleep(3500);
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
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