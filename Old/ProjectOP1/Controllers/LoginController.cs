using ProjectOP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOP1.Controllers
{
    public class LoginController : Controller
    {
        // private readonly DBContext;

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = "Login Page.";

            return View();
        }
        [HttpPost]
        public ActionResult LoginIndex( /* string email , string password */  UserModel user)
        {

            if (user == null)
            {
                return Content("Wrong username or password");
            }
            
        }
    }
}