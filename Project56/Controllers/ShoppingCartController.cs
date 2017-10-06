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
    public class ShoppingCartController : Controller
    {
       
        [HttpGet]
        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}