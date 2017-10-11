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
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Register(Users u ){

            if (u != null){
                // Default registration
                u.l_show = 1;
                u.user_level = 0 ;

               _context.users_db_set.Add(u);
               _context.SaveChanges();
            }
        }
  
    }
}


