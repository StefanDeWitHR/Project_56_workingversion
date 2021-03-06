using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Project56.Models

{
    public  class OrdStatus {
        public int id {get;set;}     
        public string description{get;set;}
        public int l_show {get;set;}
        public DateTime dt_created {get;set;}
        public DateTime dt_modified {get;set;}   
    }
    public  class OrdMains {
        public int id {get;set;}  
        
        public int user_id {get;set;}
        public int ordstatus_id {get;set;}
        public DateTime dt_order {get;set;}
        public DateTime dt_delivery{get;set;}

        public int l_show {get;set;}
        public DateTime dt_created {get;set;}
        public DateTime dt_modified {get;set;}   
    }
    public  class OrdHistory {
        public int id {get;set;}
        public string description{get;set;}
        public int l_show {get;set;}
        public DateTime dt_created {get;set;}
        public DateTime dt_modified {get;set;}   
    }
    public  class OrdLines {
        public int id {get;set;}           
        public int itm_id {get;set;}
        public int ord_id {get;set;}
        public float qty {get;set;}
        public int l_show {get;set;}
        public DateTime dt_created {get;set;}
        public DateTime dt_modified {get;set;}   
    }
}