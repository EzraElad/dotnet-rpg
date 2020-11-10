using dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // When you working with code first approach with every DbSet you add EF knows to create a table
        // Pluralize the name of the model so you could have an appropriate table name
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
