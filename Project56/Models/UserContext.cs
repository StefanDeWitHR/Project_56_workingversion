using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Project56.Models

{

    public class UserContext : DbContext{

        public DbSet<Users> users_db_set { get; set;}
        public UserContext(DbContextOptions<UserContext> options):base(options){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        
            
            if(!optionsBuilder.IsConfigured){

            }
        }

    }
    public  class Users {
        public int id {get;set;}
        public string email  {get;set;}
        public string password {get;set;}   
        public int user_level {get;set;}
        
          public  List<Users> IsValid(string email , string password , UserContext _context){
  
            List<Users> result = _context.users_db_set.Where(u => u.email == email && u.password == password).ToList();
            return result;
          }  
    }
}