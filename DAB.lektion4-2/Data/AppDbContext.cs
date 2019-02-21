using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DAB.lektion4_2.Data
{
    class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Electronics.db");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<PC> PCs { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Printer> Printers { get; set; }
    }
}
