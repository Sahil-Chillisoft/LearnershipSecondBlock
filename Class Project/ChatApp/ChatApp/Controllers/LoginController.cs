using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatApp.Domain.Models;

namespace ChatApp.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(string loginStatus = "")
        {
            if (!string.IsNullOrEmpty(loginStatus))
                ViewBag.LoginStatus = "LoginFailed";

            return View();
        }

        [HttpPost]
        public IActionResult PerformLoginAction(string authenticationResponse)
        {
            if (authenticationResponse == "Authenticated")
                return RedirectToAction("Index", "Dashboard");
            else
                return Index("loginFailed");
        }
    }
}
