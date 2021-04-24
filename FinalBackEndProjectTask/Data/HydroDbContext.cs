using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalBackEndProjectTask.Data
{
    public class HydroDbContext : DbContext
    {
        public HydroDbContext() : base("myDbConnection")
        {

        }
        public DbSet<comment> Comments { get; set; }
    }
}