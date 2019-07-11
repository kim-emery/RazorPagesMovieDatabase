using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstNetCoreWebApp.Models
{
    public class FirstNetCoreWebAppContext : DbContext
    {
        // name of the connection string is passed into the context by calling a method on a DbContextOptions object
        public FirstNetCoreWebAppContext (DbContextOptions<FirstNetCoreWebAppContext> options)
            : base(options)
        {
        }
        // creates property for entity set - generally corresponds to a database table, while an entity is one tow
        public DbSet<FirstNetCoreWebApp.Models.Movie> Movie { get; set; }

    }
}
