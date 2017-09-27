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
        public IActionResult Login(Users u){

            if(ModelState.IsValid){
              
               u =  u.IsValid(u.email, u.password , _context);

                if (u != null){
                        
                     if(u.user_level == 1){
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

