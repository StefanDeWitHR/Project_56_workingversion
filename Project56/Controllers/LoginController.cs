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
            
               var result = _context.users_db_set.Where(u => u.email == usr.email && u.password == usr.password).FirstOrDefault();   
               
                if (result != null){
                    
                    // set session on user_id
                   // HttpContext.Session.SetInt32("user_id", result.id);

                    HttpContext.Session.Set<Users>("Usr_object" , result );

                    // remove session  = Context.Session.Remove("Name");

                    var ReadSession = HttpContext.Session.Get<Users>("Usr_object");


                     if(result.user_level == 1){
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


