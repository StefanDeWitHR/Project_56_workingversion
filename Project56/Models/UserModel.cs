using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Project56.Models

{
    public  class Users {
        public int id {get;set;}
        public string email  {get;set;}    
        public string password {get;set;}   
        public int user_level {get;set;}

        public string fullname {get;set;}
        public string zipcode {get;set;}
        public string street {get;set;}
        public string streetnumber {get;set;}
        public string delivery_adres {get;set;}
        
        public string dt_birth {get;set;}
        public string gender {get;set;}
        public int l_show {get;set;}
        public DateTime dt_created {get;set;}
        public DateTime dt_modified {get;set;}
        
          public  Users IsValid(string email , string password , DBModel _context){
  
            Users result = _context.users_db_set.Where(u => u.email == email && u.password == password).FirstOrDefault();
            return result;
          }  
          
    }
}