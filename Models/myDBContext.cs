using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataDrunk.Models
{
    public class myDBContext : DbContext
    {
        public DbSet<ContactModels> Contacts { get; set; }
        public myDBContext()
            : base("DataDrunk")
        {

        }
        
       
    }
}