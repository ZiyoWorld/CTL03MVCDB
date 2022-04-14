using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CTL03MVCDB.Models
{
    public class PhoneInit : DropCreateDatabaseIfModelChanges<ContextDB>
    {
        protected override void Seed(ContextDB context)
        {
            base.Seed(context);

            var phones = new List<Phone>
            {
                new Phone {Name = "Mirziyod", PNumber = "+375259478867" },
                new Phone {Name = "Mirziyod", PNumber = "+375259478867" }
            };

            phones.ForEach(s => context.Phones.Add(s));
            context.SaveChanges();
        }
    }
}