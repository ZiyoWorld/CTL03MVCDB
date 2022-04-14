using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CTL03MVCDB.Models
{
    public class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PNumber { get; set; }
    }
}