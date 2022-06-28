using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Data.Configurations;

namespace Data
{
    public class ProductManagementContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ChemicalConfiguration());
            modelBuilder.ApplyConfiguration(new FactureConfiguration());
            modelBuilder.Entity<Chemical>().OwnsOne(s => s.MyAddress);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
               .UseSqlServer(@"Server=localhost;Database=GestionProduitDb;Trusted_Connection=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Chemical> Chemicals { get; set; }

        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
