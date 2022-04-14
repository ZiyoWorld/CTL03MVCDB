using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CTL03MVCDB.Models
{
    public class ContextDB : DbContext
    {
        public ContextDB() : base("DbPhones")
        {
            Database.SetInitializer<ContextDB>(new PhoneInit());
        }
        public DbSet<Phone> Phones { get; set; }
    }       
}