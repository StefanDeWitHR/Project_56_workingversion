using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project56.Models;

namespace Project56.Controllers
{
    public class HomeController : NavigatorController
    {

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
         public IActionResult ShopingCart(){
            ViewData["Message"] = "Shopping cart page";

            return View();
        }
    }
}
