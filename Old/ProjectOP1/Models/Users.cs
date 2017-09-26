using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectOP1.Models
{

    public class UserModel { 
    
        //User settings
       public  string Email { get; set; }
       public  string Password { get; set; }
       public  string Fullname { get; set; }
       public  DateTime Dt_birth { get; set; }
       public  string Gender { get; set; }

        //address settings
        string personal_address { get; set; }
        string delivery_address { get; set; }
    }
    public class User : IUser
    {
        string email;

        public void ChangePassword()
        {
            throw new NotImplementedException();
        }

        public  void Login()
        {
            throw new NotImplementedException();
        }
    }
    public class Admin : IUser
    {
        public void ChangePassword()
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }
    }
}