using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TefteriLoginTest.Models;

namespace TefteriLoginTest.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
       
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user.Username == "admin" && user.Password == "admin")
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return Redirect("~/Friend/Friends");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is invalid.");
            }

            return View(user);
        }
    }
}