using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivity.Models;

namespace Productivity.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Personen { get; set; }
        public DbSet<Umbau> Umbau { get; set; }
        public DbSet<Neubau> Neubau { get; set; }

        public DatabaseContext()
        {
            
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasKey(x => x.Id);
            builder.Entity<Umbau>().HasKey(x => x.Id);
            builder.Entity<Neubau>().HasKey(x => x.Id);

            builder.Entity<Employee>()
                .HasMany(x => x.Neubau)
                .WithOne(x => x.Employee);

            builder.Entity<Employee>()
                .HasMany(x => x.Umbau)
                .WithOne(x => x.Employee);
               
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
