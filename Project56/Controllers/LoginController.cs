using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project56.Models;


namespace Project56.Controllers
{
    public class LoginController : Controller
    {
        private readonly DBModel _context;

        public LoginController (DBModel context) {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Users usr){

            if(ModelState.IsValid){
            
               usr = _context.users_db_set.Where(u => u.email == u.email && u.password == u.password).FirstOrDefault();   
                if (usr != null){
                        
                     if(usr.user_level == 1){
                         // admin login
                        return RedirectToAction("index", "Admin");
                     }else{
                         // user login
                         return RedirectToAction("index", "User");
                     }
                    
                }else{
                  return RedirectToAction("index", "LoginIncorrect");   
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
  
    }
}


