using Jali_di.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jali_di.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            using(OurDbContext db = new OurDbContext())
            {
                return View(db.user.ToList());
            }
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.user.Single(u=>u.username == user.username && u.password == user.password);
                if (user != null) {
                    Session["id_user"] = usr.id_user.ToString();
                    Session["username"] = usr.username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password not match");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if(Session["id_user"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}