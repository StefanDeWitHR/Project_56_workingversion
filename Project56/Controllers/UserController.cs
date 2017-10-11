using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Project56.Models;

namespace Project56.Controllers
{
    public class UserController : Controller
    {

        private readonly DBModel _context;

        public UserController (DBModel context) {
            _context = context;
        
        
        }
        [HttpGet]
        public IActionResult Index()
        {
            // Try to get the session of which the user is logged in.
            // If it's not found, sets to null.
            var s = HttpContext.Session.Get<Users>("Usr_object") != null?
            HttpContext.Session.Get<Users>("Usr_object"):null;
            
            // If there is no session found, redirect to the login screen.
            if(s != null){
                Debug.WriteLine($"No session found, redirecting  - {s}");
                return RedirectToAction("index", "home"); 
            }

            return View();
        }

        public IActionResult ShowUserPage()
        {
            return null;
        }
    
    }
}
