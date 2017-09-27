using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project56.Models;


namespace Project56.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserContext _context;

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
  
    }
}


