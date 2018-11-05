using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstApplication.Models
{
    public class MyFirstApplicationContext : DbContext
    {
        public MyFirstApplicationContext (DbContextOptions<MyFirstApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstApplication.Models.Movie> Movie { get; set; }
    }
}
