using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project56.Models;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Web;

namespace Project56.Controllers
{
    public class NavigatorController : Controller
    {

        // checks if the session is SET 

        // CHECK IF ADMIN /  USER
        [HttpGet]
        public IActionResult SessionNavigator(string method_name , string controller_name){

            var ReadSession = HttpContext.Session.Get<Users>("Usr_object");

            if (ReadSession != null){

                return RedirectToAction(method_name , controller_name);
            }else{
                return RedirectToAction("index", "Login"); 
            }

        }
    }
}


