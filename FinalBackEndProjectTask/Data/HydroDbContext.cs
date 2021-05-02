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
        public virtual DbSet<Comment> Comments { get; set; }

        public virtual DbSet<AboutMeta> AboutMetas { get; set; }

        public virtual DbSet<ContactMessage> ContactMessages { get; set; }

        public virtual DbSet<Footer> Footers { get; set; }

        public virtual DbSet<Article> Articles { get; set; }

        public virtual DbSet<OurWork> OurWorks { get; set; }
    }
}