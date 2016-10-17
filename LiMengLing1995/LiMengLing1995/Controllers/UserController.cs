using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiMengLing1995.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        public ActionResult IsLogIn(string Email, string Pwd)
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }
    }
}