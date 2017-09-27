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
        private readonly DBModel _context;

        public RegisterController(DBModel context){
            _context  = context;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public void Register(Users u ){

            if (u != null){
               _context.users_db_set.Add(u);
            }
        }
  
    }
}


