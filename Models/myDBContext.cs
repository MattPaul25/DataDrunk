using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataDrunk.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("DataDrunk_Db")
        {

        }

        public DbSet<MessageModel> Message { get; set; }
    }
}