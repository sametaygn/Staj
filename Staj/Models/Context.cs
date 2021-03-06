using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj.Models
{
    public class Context:DbContext
    {
       public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
