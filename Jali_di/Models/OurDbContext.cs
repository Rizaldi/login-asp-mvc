using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Jali_di.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<User> user { get; set; }
    }

}