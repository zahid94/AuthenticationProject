using AuthenticationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthenticationProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(User user)
        {
            AuthenticationDbContext db = new AuthenticationDbContext();
            if (db.users.Any(x=>x.UserName==user.UserName&& x.password==user.password))
            {
                FormsAuthentication.SetAuthCookie(user.UserName,false);
                return RedirectToAction("Index", "DashBoard");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(User user)
        {
            AuthenticationDbContext db = new AuthenticationDbContext();
            db.users.Add(user);
            db.SaveChanges();
            return RedirectToAction("LogIn");
        }
    }
}