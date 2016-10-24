using System;
using System.Web.Mvc;
using LiMengLing1995.Business.Base;
using LiMengLing1995.Model;
using System.Collections.Generic;

namespace LiMengLing1995.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult IsLogIn(string Email, string Pwd)
        {


            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult Register()
        {
            Dictionary<int, string> Sex = EnumUtil.EnumToDictionary(enumState.userSex.Else.GetType());
            List<SelectListItem> Sexlst = new List<SelectListItem>();
            foreach (var item in Sex)
            {
                Sexlst.Add(new SelectListItem() { Text = item.Value, Value = item.Key.ToString() });
            }
            int i = 0;
            int d = 2 / i;
            IEnumerable<SelectListItem> ISexlst = Sexlst;
            ViewData["Sex"] = ISexlst;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(MengLingUser userMode)
        {
            userMode.Id = Guid.NewGuid().ToString();
            userMode.RegisterTime = DateTime.Now;
            userMode.UserSate = enumState.userState.Start.GetHashCode();
            int i = Repository<MengLingUser>.Insert(userMode);
            return View();
        }
    }
}