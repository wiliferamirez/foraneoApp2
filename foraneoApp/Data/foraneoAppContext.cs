using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using foraneoApp.Models;

namespace foraneoApp.Data
{
    public class foraneoAppContext : DbContext
    {
        public foraneoAppContext (DbContextOptions<foraneoAppContext> options)
            : base(options)
        {
        }

        public DbSet<foraneoApp.Models.Users> Users { get; set; } = default!;
    }
}
