using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Project56.Models

{

    public class DBModel : DbContext{

        public DbSet<Users> users_db_set { get; set;}
        public DbSet<Itms> itms_db_set { get; set;}
        public DbSet<ItmCategories> itmcat_db_set{get;set;}

         public DbSet<Logs> logs_db_set { get; set;}

        public DbSet<OrdMains> ordmain_db_set { get; set;}
        public DbSet<OrdLines> ordlines_db_set { get; set;}
        public DbSet<OrdHistory> ordhis_db_set { get; set;}
        public DbSet<OrdStatus> ordstatus_db_set { get; set;}
        public DBModel(DbContextOptions<DBModel> options):base(options){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        
            
            if(!optionsBuilder.IsConfigured){

            }
        }

    }
}