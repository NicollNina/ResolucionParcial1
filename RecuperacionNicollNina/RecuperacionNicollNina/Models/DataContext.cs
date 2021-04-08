using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecuperacionNicollNina.Models
{
    public class DataContext:DbContext 
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<RecuperacionNicollNina.Models.Product> Products { get; set; }
    }
}