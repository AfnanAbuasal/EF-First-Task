using EF_Task1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task1.Data
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=IMPLUTOGAL;Database=EF_Task1;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(
                eb =>
                {
                    eb.Property(b => b.Title).HasColumnType("varchar(100)");
                    eb.Property(b => b.Description).HasColumnType("varchar(300)");
                });
            modelBuilder.Entity<User>(
                eb =>
                {
                    eb.Property(b => b.Name).HasColumnType("varchar(100)");
                    eb.Property(b => b.Email).HasColumnType("varchar(100)");
                    eb.Property(b => b.Password).HasColumnType("varchar(100)");
                });
        }
    }
}
